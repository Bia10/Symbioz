


















// Generated on 06/04/2015 18:45:36
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Types
{

public class ShortcutObjectItem : ShortcutObject
{

public const short Id = 371;
public override short TypeId
{
    get { return Id; }
}

public int itemUID;
        public int itemGID;
        

public ShortcutObjectItem()
{
}

public ShortcutObjectItem(sbyte slot, int itemUID, int itemGID)
         : base(slot)
        {
            this.itemUID = itemUID;
            this.itemGID = itemGID;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteInt(itemUID);
            writer.WriteInt(itemGID);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            itemUID = reader.ReadInt();
            itemGID = reader.ReadInt();
            

}


}


}