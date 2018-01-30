﻿using System.Data.SqlClient;
using Shouldly;
using Xunit;

namespace YiHan.Cms.Tests.General
{
    public class ConnectionString_Tests
    {
        [Fact]
        public void SqlConnectionStringBuilder_Test()
        {
            var csb = new SqlConnectionStringBuilder("Server=localhost; Database=Cms; Trusted_Connection=True;");
            csb["Database"].ShouldBe("Cms");
        }
    }
}
