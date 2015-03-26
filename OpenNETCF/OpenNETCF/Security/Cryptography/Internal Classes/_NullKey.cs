//http://www.phdcc.com/cryptorc4.htm
using System;

namespace OpenNETCF.Security.Cryptography.Internal
{
	internal class NullKey
	{
		//The example needs (MS Enhanced Crypto Service Provider) 128 bit encryption 
		//to work and will only work with a 16 byte (128 bit) RC4 key; 
		//it will not work with smaller key lengths. 
		//However if you only have or select the MS Basic Crypto Service Provider
		//then the code will work (and only work) with 5 byte (40 bit) keys.

		// This is a PRIVATEKEYBLOB blob with an exponent of one keypair,
		// ie it allows keys to be exported/imported without changing the key data.
		public static byte [] PrivateKeyWithExponentOfOne =
		{
			0x07, 0x02, 0x00, 0x00, 0x00, 0xA4, 0x00, 0x00,
			0x52, 0x53, 0x41, 0x32, 0x00, 0x02, 0x00, 0x00,
			0x01, 0x00, 0x00, 0x00, 0xAB, 0xEF, 0xFA, 0xC6,
			0x7D, 0xE8, 0xDE, 0xFB, 0x68, 0x38, 0x09, 0x92,
			0xD9, 0x42, 0x7E, 0x6B, 0x89, 0x9E, 0x21, 0xD7,
			0x52, 0x1C, 0x99, 0x3C, 0x17, 0x48, 0x4E, 0x3A,
			0x44, 0x02, 0xF2, 0xFA, 0x74, 0x57, 0xDA, 0xE4,
			0xD3, 0xC0, 0x35, 0x67, 0xFA, 0x6E, 0xDF, 0x78,
			0x4C, 0x75, 0x35, 0x1C, 0xA0, 0x74, 0x49, 0xE3,
			0x20, 0x13, 0x71, 0x35, 0x65, 0xDF, 0x12, 0x20,
			0xF5, 0xF5, 0xF5, 0xC1, 0xED, 0x5C, 0x91, 0x36,
			0x75, 0xB0, 0xA9, 0x9C, 0x04, 0xDB, 0x0C, 0x8C,
			0xBF, 0x99, 0x75, 0x13, 0x7E, 0x87, 0x80, 0x4B,
			0x71, 0x94, 0xB8, 0x00, 0xA0, 0x7D, 0xB7, 0x53,
			0xDD, 0x20, 0x63, 0xEE, 0xF7, 0x83, 0x41, 0xFE,
			0x16, 0xA7, 0x6E, 0xDF, 0x21, 0x7D, 0x76, 0xC0,
			0x85, 0xD5, 0x65, 0x7F, 0x00, 0x23, 0x57, 0x45,
			0x52, 0x02, 0x9D, 0xEA, 0x69, 0xAC, 0x1F, 0xFD,
			0x3F, 0x8C, 0x4A, 0xD0,

			0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
			0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
			0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
			0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,

			0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
			0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
			0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
			0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,

			0x64, 0xD5, 0xAA, 0xB1,
			0xA6, 0x03, 0x18, 0x92, 0x03, 0xAA, 0x31, 0x2E,
			0x48, 0x4B, 0x65, 0x20, 0x99, 0xCD, 0xC6, 0x0C,
			0x15, 0x0C, 0xBF, 0x3E, 0xFF, 0x78, 0x95, 0x67,
			0xB1, 0x74, 0x5B, 0x60,

			0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
			0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
			0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
			0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
			0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
			0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
			0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
			0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
		};

		public static byte [] SimpleBlobRC4KeyTemplate =
		{
			0x01, 0x02, 0x00, 0x00,        // BLOBHEADER bType, bVersion, reserved
			0x01, 0x68, 0x00, 0x00,        // BLOBHEADER aiKeyAlg: CALG_RC4
			0x00, 0xA4, 0x00, 0x00,        // algid used to encrypt blob: CALG_RSA_KEYX
			// Rest is a PKCS #1, type 2 encryption block:
			// For MS Base CP this is always 512 bits (64 bytes)
			0x0F, 0x0E, 0x0D, 0x0C,        // Key Material: 16 byte actual RC4 key goes in reverse from here
			0x0B, 0x0A, 0x09, 0x08,
			0x07, 0x06, 0x05, 0x04,
			0x03, 0x02, 0x01, 0x00,        // to here (15 to 0 countdown)
			0x00, 0x3D, 0xB5, 0xE1,        // Zero then Random non-zero padding..
			0x5B, 0x27, 0x13, 0x36,
			0x69, 0x9B, 0x56, 0xA9,
			0x52, 0x98, 0x5B, 0xA9,
			0x17, 0x24, 0x1D, 0x1A,
			0x2B, 0x9C, 0xE7, 0x35,
			0x3C, 0xC9, 0xD6, 0xE1,
			0xD7, 0x70, 0xCC, 0x70,
			0x94, 0x6B, 0x90, 0xD0,
			0x7E, 0x92, 0x2E, 0x5C,
			0x80, 0xDB, 0xE5, 0x2D,
			0x60, 0x75,                    // ..Padding
			0x02, 0x00,                    // Block type; reserved
		};
	}
}