﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Data.Common;
using System.Data;

namespace DataAccess.SqlAccess;

public class SqlAccess : ISqlAccess
{

    /// <summary>
    /// This is the class that use to connect to DB , User needs to determince connection string.
    /// </summary>
    /// <param name="_stringConnection">Connection string that will use entire SqlAccess Class </param>
    private readonly string _stringConnection;

    public SqlAccess(IXmlAccess xmlAccess)
    {
        if (xmlAccess == null) throw new ArgumentNullException(nameof(xmlAccess));

        _stringConnection = xmlAccess.ReadConnectionString();
        if (string.IsNullOrEmpty(_stringConnection))
        {
            throw new InvalidOperationException("Connection string cannot be null or empty.");
        }
    }




    /// <summary>
    /// Asynchronously loads data from the database using a stored procedure.
    /// </summary>
    /// <typeparam name="T">The model class that the result set will be mapped to.</typeparam>
    /// <typeparam name="U">The type of the parameters being passed to the stored procedure.</typeparam>
    /// <param name="storedProcedure">The name of the stored procedure to execute.</param>
    /// <param name="parameters">The parameters to pass to the stored procedure.</param>
    /// <returns>A collection of model objects populated with the query results.</returns>
    public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters)
    {
        using IDbConnection connection = new SqlConnection(_stringConnection);
        return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
    }

    /// <summary>
    /// Asynchronously saves data to the database using a stored procedure.
    /// </summary>
    /// <typeparam name="T">The type of the parameters being passed to the stored procedure.</typeparam>
    /// <param name="storedProcedure">The name of the stored procedure to execute.</param>
    /// <param name="parameters">The parameters to pass to the stored procedure.</param>

    public async Task SaveData<T>(string storedProcedure, T parameters)
    {
        using IDbConnection connection = new SqlConnection(_stringConnection);
        await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
    }

}
