using Microsoft.Data.Sqlite;
using System.Data;

namespace GymMembershipManagementSystem
{
    public static class DatabaseHelper
    {
        private const string ConnectionString =
            "Data Source=gym_membership.db";

        public static void InitializeDatabase()
        {
            using SqliteConnection connection =
                new SqliteConnection(ConnectionString);

            connection.Open();

            string createMembersTable = @"
                CREATE TABLE IF NOT EXISTS Members
                (
                    MemberID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Phone TEXT,
                    Email TEXT,
                    JoinDate TEXT NOT NULL
                );";

            using SqliteCommand memberCommand =
                new SqliteCommand(createMembersTable, connection);

            memberCommand.ExecuteNonQuery();


            string createMembershipsTable = @"
                CREATE TABLE IF NOT EXISTS Memberships
                (
                    MembershipID INTEGER PRIMARY KEY AUTOINCREMENT,
                    MemberID INTEGER NOT NULL,
                    MembershipType TEXT NOT NULL,
                    StartDate TEXT NOT NULL,
                    ExpiryDate TEXT NOT NULL,
                    Fee REAL NOT NULL,
                    PaymentStatus TEXT NOT NULL,
                    MembershipStatus TEXT NOT NULL,
                    FOREIGN KEY (MemberID)
                        REFERENCES Members(MemberID)
                );";

            using SqliteCommand membershipCommand =
                new SqliteCommand(createMembershipsTable, connection);

            membershipCommand.ExecuteNonQuery();
        }
        public static void AddMember(Member member, Membership membership)
        {
            using SqliteConnection connection =
                new SqliteConnection(ConnectionString);

            connection.Open();

            using var transaction = connection.BeginTransaction();

            try
            {
                string memberQuery = @"
            INSERT INTO Members
            (Name, Phone, Email, JoinDate)
            VALUES
            ($name, $phone, $email, $joinDate);";

                using SqliteCommand memberCommand =
                    new SqliteCommand(memberQuery, connection, transaction);

                memberCommand.Parameters.AddWithValue("$name", member.Name);
                memberCommand.Parameters.AddWithValue("$phone", member.Phone);
                memberCommand.Parameters.AddWithValue("$email", member.Email);
                memberCommand.Parameters.AddWithValue(
                    "$joinDate",
                    member.JoinDate.ToString("yyyy-MM-dd"));

                memberCommand.ExecuteNonQuery();

                using SqliteCommand idCommand =
                    new SqliteCommand(
                        "SELECT last_insert_rowid();",
                        connection,
                        transaction);

                int newMemberID =
                    Convert.ToInt32(idCommand.ExecuteScalar());

                string membershipQuery = @"
            INSERT INTO Memberships
            (
                MemberID,
                MembershipType,
                StartDate,
                ExpiryDate,
                Fee,
                PaymentStatus,
                MembershipStatus
            )
            VALUES
            (
                $memberID,
                $type,
                $startDate,
                $expiryDate,
                $fee,
                $paymentStatus,
                $membershipStatus
            );";

                using SqliteCommand membershipCommand =
                    new SqliteCommand(
                        membershipQuery,
                        connection,
                        transaction);

                membershipCommand.Parameters.AddWithValue(
                    "$memberID", newMemberID);

                membershipCommand.Parameters.AddWithValue(
                    "$type", membership.MembershipType);

                membershipCommand.Parameters.AddWithValue(
                    "$startDate",
                    membership.StartDate.ToString("yyyy-MM-dd"));

                membershipCommand.Parameters.AddWithValue(
                    "$expiryDate",
                    membership.ExpiryDate.ToString("yyyy-MM-dd"));

                membershipCommand.Parameters.AddWithValue(
                    "$fee", membership.Fee);

                membershipCommand.Parameters.AddWithValue(
                    "$paymentStatus", membership.PaymentStatus);

                membershipCommand.Parameters.AddWithValue(
                    "$membershipStatus", membership.MembershipStatus);

                membershipCommand.ExecuteNonQuery();

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public static DataTable GetMembers(string searchText = "")
        {
            using SqliteConnection connection =
                new SqliteConnection(ConnectionString);

            connection.Open();

            string query = @"
        SELECT
            m.MemberID,
            m.Name,
            m.Phone,
            m.Email,
            m.JoinDate,
            ms.MembershipType,
            ms.StartDate,
            ms.ExpiryDate,
            ms.Fee,
            ms.PaymentStatus,
            ms.MembershipStatus
        FROM Members m
        LEFT JOIN Memberships ms
            ON m.MemberID = ms.MemberID
        WHERE
            $search = ''
            OR m.Name LIKE '%' || $search || '%'
            OR m.Phone LIKE '%' || $search || '%'
            OR m.Email LIKE '%' || $search || '%'
            OR CAST(m.MemberID AS TEXT)
               LIKE '%' || $search || '%'
        ORDER BY m.MemberID DESC;
    ";

            using SqliteCommand command =
                new SqliteCommand(query, connection);

            command.Parameters.AddWithValue(
                "$search", searchText);

            using SqliteDataReader reader =
                command.ExecuteReader();

            DataTable table = new DataTable();

            table.Load(reader);

            return table;
        }
        public static void DeleteMember(int memberID)
        {
            using SqliteConnection connection =
                new SqliteConnection(ConnectionString);

            connection.Open();

            using var transaction = connection.BeginTransaction();

            try
            {
                string deleteMembershipQuery =
                    "DELETE FROM Memberships WHERE MemberID = $memberID;";

                using SqliteCommand membershipCommand =
                    new SqliteCommand(
                        deleteMembershipQuery,
                        connection,
                        transaction);

                membershipCommand.Parameters.AddWithValue(
                    "$memberID", memberID);

                membershipCommand.ExecuteNonQuery();


                string deleteMemberQuery =
                    "DELETE FROM Members WHERE MemberID = $memberID;";

                using SqliteCommand memberCommand =
                    new SqliteCommand(
                        deleteMemberQuery,
                        connection,
                        transaction);

                memberCommand.Parameters.AddWithValue(
                    "$memberID", memberID);

                memberCommand.ExecuteNonQuery();

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public static DataRow? GetMemberById(int memberID)
        {
            using SqliteConnection connection =
                new SqliteConnection(ConnectionString);

            connection.Open();

            string query = @"
        SELECT
            m.MemberID,
            m.Name,
            m.Phone,
            m.Email,
            m.JoinDate,
            ms.MembershipType,
            ms.StartDate,
            ms.ExpiryDate,
            ms.Fee,
            ms.PaymentStatus,
            ms.MembershipStatus
        FROM Members m
        LEFT JOIN Memberships ms
            ON m.MemberID = ms.MemberID
        WHERE m.MemberID = $memberID;
    ";

            using SqliteCommand command =
                new SqliteCommand(query, connection);

            command.Parameters.AddWithValue("$memberID", memberID);

            using SqliteDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            if (table.Rows.Count == 0)
                return null;

            return table.Rows[0];
        }
        public static void UpdateMember(
    int memberID,
    Member member,
    Membership membership)
        {
            using SqliteConnection connection =
                new SqliteConnection(ConnectionString);

            connection.Open();

            using var transaction = connection.BeginTransaction();

            try
            {
                string memberQuery = @"
            UPDATE Members
            SET Name = $name,
                Phone = $phone,
                Email = $email,
                JoinDate = $joinDate
            WHERE MemberID = $memberID;
        ";

                using SqliteCommand memberCommand =
                    new SqliteCommand(
                        memberQuery,
                        connection,
                        transaction);

                memberCommand.Parameters.AddWithValue("$name", member.Name);
                memberCommand.Parameters.AddWithValue("$phone", member.Phone);
                memberCommand.Parameters.AddWithValue("$email", member.Email);
                memberCommand.Parameters.AddWithValue(
                    "$joinDate",
                    member.JoinDate.ToString("yyyy-MM-dd"));
                memberCommand.Parameters.AddWithValue(
                    "$memberID",
                    memberID);

                memberCommand.ExecuteNonQuery();

                string membershipQuery = @"
            UPDATE Memberships
            SET MembershipType = $type,
                StartDate = $startDate,
                ExpiryDate = $expiryDate,
                Fee = $fee,
                PaymentStatus = $paymentStatus,
                MembershipStatus = $membershipStatus
            WHERE MemberID = $memberID;
        ";

                using SqliteCommand membershipCommand =
                    new SqliteCommand(
                        membershipQuery,
                        connection,
                        transaction);

                membershipCommand.Parameters.AddWithValue(
                    "$type",
                    membership.MembershipType);

                membershipCommand.Parameters.AddWithValue(
                    "$startDate",
                    membership.StartDate.ToString("yyyy-MM-dd"));

                membershipCommand.Parameters.AddWithValue(
                    "$expiryDate",
                    membership.ExpiryDate.ToString("yyyy-MM-dd"));

                membershipCommand.Parameters.AddWithValue(
                    "$fee",
                    membership.Fee);

                membershipCommand.Parameters.AddWithValue(
                    "$paymentStatus",
                    membership.PaymentStatus);

                membershipCommand.Parameters.AddWithValue(
                    "$membershipStatus",
                    membership.MembershipStatus);

                membershipCommand.Parameters.AddWithValue(
                    "$memberID",
                    memberID);

                membershipCommand.ExecuteNonQuery();

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
    }
}