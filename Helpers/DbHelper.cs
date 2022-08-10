using DTPersonalInfoTracker.DbContexts;
using DTPersonalInfoTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace DTPersonalInfoTracker.Helpers;

public class DbHelper
{
    public static IList<PersonelModel> ConvertData(IList<RootObject> rawList)
    {
        var result = new List<PersonelModel>();

        foreach (var data in rawList)
        {
            var pModel = new PersonelModel
            {
                RecordId = data.RecordId!,
                Ad = data.FieldList.FirstOrDefault(x => x?.LogicalName == "hs_name")?.Value,
                Soyad = data.FieldList.FirstOrDefault(x => x?.LogicalName == "hs_surname")?.Value,
                Grup = data.FieldList.FirstOrDefault(x => x?.LogicalName == "hs_parentunitid")?.Value,
                PozisyonSeviyesi = data.FieldList.FirstOrDefault(x => x?.LogicalName == "hs_positionlevelid")?.Value,
                Bolum = data.FieldList.FirstOrDefault(x => x?.LogicalName == "hs_pparentunitid")?.Value,
                Pozisyon = data.FieldList.FirstOrDefault(x => x?.LogicalName == "hs_positionid")?.Value,
                CepNumarasi = data.FieldList.FirstOrDefault(x => x?.LogicalName == "hs_companyphone")?.Value,
                SirketEmail = data.FieldList.FirstOrDefault(x => x?.LogicalName == "emailaddress")?.Value,
                SicilNo = data.FieldList.FirstOrDefault(x => x?.LogicalName == "hs_personnelno")?.Value,
                Birim = data.FieldList.FirstOrDefault(x => x?.LogicalName == "hs_ppparentunitid")?.Value,
                Yonetici = data.FieldList.FirstOrDefault(x => x?.LogicalName == "hs_reportmanagerid")?.Value
            };

            result.Add(pModel);
        }

        return result;
    }

    public static void AddFieldListsToDb(IList<PersonelModel> personelModels)
    {
        using var context = new PITDbContext();
        InitializeDb(context);

        TruncateTable(context);
        context.Personels.AddRange(personelModels);
        context.SaveChanges();
        LoggerHelper.Information("Personel list successfully added to database.");
        LoggerHelper.LogToDb(context, new LogModel {Date = DateTime.Now, OperationName = "Update", Message = "Personel list successfully added to database"});
    }

    public static void InitializeDb(PITDbContext context)
    {
        if (context.Database.GetPendingMigrations().Any())
        {
            context.Database.Migrate();
            LoggerHelper.Information("DTPIT db created and migrated.");
        }
    }

    public static void TruncateTable(PITDbContext context)
    {
        context.Personels.RemoveRange(context.Personels);
        LoggerHelper.Information("Personel table truncated.");
        LoggerHelper.LogToDb(context, new LogModel {Date = DateTime.Now, OperationName = "Truncate", Message = "Personel table truncated."});
    }
}