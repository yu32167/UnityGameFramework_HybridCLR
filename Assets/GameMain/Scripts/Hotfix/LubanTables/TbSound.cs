//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace Game.Hotfix.Cfg
{

public sealed partial class TbSound
{
    private readonly Dictionary<int, Item.Sound> _dataMap;
    private readonly List<Item.Sound> _dataList;
    
    public TbSound(JSONNode _json)
    {
        _dataMap = new Dictionary<int, Item.Sound>();
        _dataList = new List<Item.Sound>();
        
        foreach(JSONNode _row in _json.Children)
        {
            var _v = Item.Sound.DeserializeSound(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public Dictionary<int, Item.Sound> DataMap => _dataMap;
    public List<Item.Sound> DataList => _dataList;

    public Item.Sound GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Item.Sound Get(int key) => _dataMap[key];
    public Item.Sound this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
    
    
    partial void PostInit();
    partial void PostResolve();
}

}