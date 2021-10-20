using System.Xml.Linq;

XElement purcharseorder = XElement.Load("purchaseorder.xml");

var items = purcharseorder
    .Element("Items")
    ?.Elements("Item")
    ?.Where(item => item.Attribute("PartNumber")?.Value?.Contains('B') ?? false)
    ?.ToList()
    ?? new List<XElement>();

foreach (var item in items)
{

}