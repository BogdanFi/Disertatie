using Mediator;

var privateChat = new ChatMediator();
var bogdanUser = new User("Bogdan", privateChat);
var florinUser = new User("Florin", privateChat);
var ciprianUser = new User("Ciprian", privateChat);

bogdanUser.Send("Salut. Eu sunt Bogdan. Voi cum vă numiți?");
florinUser.Send("Salut. Eu sunt Florin, încântat de cunoștință.");
ciprianUser.Send("Salut. Eu sunt Ciprian, scuze de întârziere.");