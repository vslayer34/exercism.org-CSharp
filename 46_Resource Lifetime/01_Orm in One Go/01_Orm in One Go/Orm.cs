﻿using System;
using System.Linq.Expressions;

public class Orm
{
    private Database database;

    public Orm(Database database)
    {
        this.database = database;
    }

    public void Write(string data)
    {
        using (database)
        {
            database.BeginTransaction();
            database.Write(data);
            database.EndTransaction();
        }
    }

    public bool WriteSafely(string data)
    {
        using (database)
        {
            try
            {
                database.BeginTransaction();
                database.Write(data);
                database.EndTransaction();
                return true;
            }
            catch (InvalidOperationException)
            {
                database.Dispose();
                return false;
            }
        }
    }
}