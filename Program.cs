using DTPersonalInfoTracker.Helpers;
using DTPersonalInfoTracker.Models;

var appSettings = SettingsHelper.GetSettings();

var response = await FetchDataHelper.FetchXmlData(appSettings.ApiUrl, appSettings.ActionName, appSettings.FetchXml,
    appSettings.DomainName);

var serializedObject = SerializerHelper.Deserialize<RawResponse>(response);

var list = SerializerHelper.Deserialize<IList<RootObject>>(serializedObject.JsonObject);

var data = DbHelper.ConvertData(list);

DbHelper.AddFieldListsToDb(data);