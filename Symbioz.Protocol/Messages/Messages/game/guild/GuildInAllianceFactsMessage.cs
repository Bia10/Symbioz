


















// Generated on 06/04/2015 18:44:44
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class GuildInAllianceFactsMessage : GuildFactsMessage
{

public const ushort Id = 6422;
public override ushort MessageId
{
    get { return Id; }
}

public Types.BasicNamedAllianceInformations allianceInfos;
        

public GuildInAllianceFactsMessage()
{
}

public GuildInAllianceFactsMessage(Types.GuildFactSheetInformations infos, int creationDate, ushort nbTaxCollectors, bool enabled, IEnumerable<Types.CharacterMinimalInformations> members, Types.BasicNamedAllianceInformations allianceInfos)
         : base(infos, creationDate, nbTaxCollectors, enabled, members)
        {
            this.allianceInfos = allianceInfos;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            allianceInfos.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            allianceInfos = new Types.BasicNamedAllianceInformations();
            allianceInfos.Deserialize(reader);
            

}


}


}