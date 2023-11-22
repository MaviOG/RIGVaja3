using System;

public class UserAccount {
	private User user;
	private List<Property> favorites;
	private List<Property> history;
	private List<Notification> notifications;

	public void AddToFavorites(ref Property property) {
		throw new System.NotImplementedException("Not implemented");
	}
	public void AddToHistory(ref Property property) {
		throw new System.NotImplementedException("Not implemented");
	}
	public void ReceiveNotification(ref Notification notification) {
		throw new System.NotImplementedException("Not implemented");
	}
	public List<Notification> GetNotifications() {
		return this.notifications;
	}

}
