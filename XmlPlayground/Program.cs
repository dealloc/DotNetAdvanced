using System.Xml.Serialization;
using XmlPlayground;

var serializer = new XmlSerializer(typeof(PurchaseOrder));
var stream = new FileStream("purchaseorder.xml", FileMode.Open, FileAccess.Read);

PurchaseOrder? purchaseorder = (PurchaseOrder?)serializer.Deserialize(stream);

purchaseorder.PurchaseOrderNumber = "99504";

var outputstream = new FileStream("result.xml", FileMode.CreateNew, FileAccess.Write);
serializer.Serialize(outputstream, purchaseorder);

return;