﻿namespace AbstractFactoryPattern.DBConnection
{
    public abstract class DatabaseFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }
}
