


















// Generated on 06/04/2015 18:44:19
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class GameFightNewRoundMessage : Message
{

public const ushort Id = 6239;
public override ushort MessageId
{
    get { return Id; }
}

public uint roundNumber;
        

public GameFightNewRoundMessage()
{
}

public GameFightNewRoundMessage(uint roundNumber)
        {
            this.roundNumber = roundNumber;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhInt(roundNumber);
            

}

public override void Deserialize(ICustomDataInput reader)
{

roundNumber = reader.ReadVarUhInt();
            if (roundNumber < 0)
                throw new Exception("Forbidden value on roundNumber = " + roundNumber + ", it doesn't respect the following condition : roundNumber < 0");
            

}


}


}