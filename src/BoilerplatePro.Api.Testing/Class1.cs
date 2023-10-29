#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using BoilerplatePro.Testing.Bases;
using IdentityModel.Client;
using NUnit.Framework;

namespace BoilerplatePro.Api.Testing;

public abstract class BaseApiTest : IntegrationTest<BaseApiTest, Startup>
{
    [OneTimeSetUp]
    public virtual async Task SetupFixture()
    {
        await ResetDatabase();
        var accessToken = await GetAccessToken("admin@admin.com", "ASDFasdf!");
        ApiClient.SetBearerToken(accessToken);
    }

    [OneTimeTearDown]
    public virtual async Task TeardownFixture()
    {
        await DeleteDatabase();
    }
    


}