using System;

public interface Property {

	bool Filter(ref List properties);
	void AddToFavorites(ref Property property);
	void CommentAndRate(ref Property property, ref String comment, ref int rating);

}
