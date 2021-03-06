﻿namespace SimpleCoin.Node.Transactions
{
	using System;

	/// <summary>
	/// Transaction inputs (txIn) provide the information “where” the coins are coming from. 
	/// Each txIn refer to an earlier output, from which the coins are ‘unlocked’, with the 
	/// signature. These unlocked coins are now ‘available’ for the txOuts. The signature gives 
	/// proof that only the user, that has the private-key of the referred public-key 
	/// ( =address) could have created the transaction.
	/// </summary>
	public class TxIn : ICloneable
	{
		public string TxOutId { get; set; }

		public int TxOutIndex { get; set; }

		public string Signature { get; set; }

		/// <inheritdoc />
		public object Clone()
		{
			return new TxIn
			{
				TxOutId = this.TxOutId,
				TxOutIndex = this.TxOutIndex,
				Signature = this.Signature,
			};
		}
	}
}