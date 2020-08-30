using System;
using System.Collections.Generic;
using FoodOrdering.Entities;
namespace FoodOrdering.DataAccessLayer
{
	/// <summary>
	/// Represents interface for the foodstore DataAccessLayer
	/// </summary>
	public interface IFoodStoreDataAccess
	{
		void AddFoodStore(IFoodStoreDataAccess foodstore);
		public List<FoodStore> GetFoodStore();

		void UpdateStoreID(FoodStore foodstore);

		void UpdateStoreName(FoodStore foodstore);
		void UpdateEmail(FoodStore foodstore);
		void UpdatePhone(FoodStore foodstore);
		void UpdateLocation(FoodStore foodstore);
		void UpdateRating(FoodStore foodstore);

	}
}
