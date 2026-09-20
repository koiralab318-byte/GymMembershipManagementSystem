using Microsoft.Data.Sqlite;

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
    }
}