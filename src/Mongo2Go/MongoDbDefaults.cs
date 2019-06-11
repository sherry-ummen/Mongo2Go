﻿namespace Mongo2Go
{
    public static class MongoDbDefaults
    {
        public const string ProcessName = "mongod";

        public const string MongodExecutable = "mongod";

        public const string MongoExportExecutable = "mongoexport";

        public const string MongoImportExecutable = "mongoimport";

        public const int DefaultPort = 27017;

        // but we don't want to get in trouble with productive systems
        public static int TestStartPort { get; set; } = 27018;

        public const string Lockfile = "mongod.lock";
    }
}
