﻿namespace EI.SI
{
  public enum ProtocolSICmdType
  {
    NORMAL,
    ACK,
    NACK,
    DATA,
    SYM_CIPHER_DATA,
    ASSYM_CIPHER_DATA,
    SECRET_KEY,
    IV,
    PADDING,
    MODE,
    EOF,
    EOT,
    PUBLIC_KEY,
    DIGITAL_SIGNATURE,
    USER_OPTION_1,
    USER_OPTION_2,
    USER_OPTION_3,
    USER_OPTION_4,
    USER_OPTION_5,
    USER_OPTION_6,
    USER_OPTION_7,
    USER_OPTION_8,
    USER_OPTION_9,
  }
}
