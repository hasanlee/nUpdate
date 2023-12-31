﻿// StatisticsServer.cs, 10.06.2019
// Copyright (C) Dominic Beger 17.06.2019

using System;

namespace nUpdate.Administration
{
    [Serializable]
    public class StatisticsServer
    {
        public StatisticsServer(string webUrl, string databaseName, string username)
        {
            WebUrl = webUrl;
            DatabaseName = databaseName;
            Username = username;
        }

        /// <summary>
        ///     The name of the database to use.
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        ///     The username for the SQL-connection.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        ///     The url of the SQL-host.
        /// </summary>
        public string WebUrl { get; set; }
    }
}