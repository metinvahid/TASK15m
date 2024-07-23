using Task15.Models.Entities;

namespace Task15.Models.Contexts
{
    public static class DataSeed
    {

        internal static IApplicationBuilder Seed(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DataContext>();

                var list = new[]
                {
                    new Country { Name = "Azerbaijan", Code = " +994", Id = 1 },
                 new Country { Name = "Turkey", Code = "+90", Id = 2 },
                 new Country { Name = "Czechia", Code = "+420" , Id = 3 },
                 new Country { Name = "Poland", Code = "+90" , Id = 4 }


                };

                db.Countries.AddRange(list);
                db.SaveChanges();
            }
                return app;
        }
    }
}
