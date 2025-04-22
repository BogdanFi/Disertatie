using AbstractFactory;
using AbstractFactory.Mac;
using AbstractFactory.Windows;

var windows = new WindowsFactory();
var mac = new MacFactory();

var windowsApp = new Application(windows);
var macApp = new Application(mac);

windowsApp.RenderUI();
macApp.RenderUI();