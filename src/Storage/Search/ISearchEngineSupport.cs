﻿namespace SenseNet.ContentRepository.Storage.Search
{
    public interface ISearchEngineSupport
    {
        bool RestoreIndexOnstartup();
        int[] GetNotIndexedNodeTypeIds();
        IPerFieldIndexingInfo GetPerFieldIndexingInfo(string fieldName);
        bool IsContentTypeIndexed(string contentTypeName);
        bool TextExtractingWillBePotentiallySlow(IIndexableField field);
        string ReplaceQueryTemplates(string luceneQueryText);
        T GetSettingsValue<T>(string key, T defaultValue);
    }
}
