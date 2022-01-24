// See https://aka.ms/new-console-template for more information
using LSP.Animals;
using LSP.Interfaces;


var turtle = new Turtle();
var lion = new Lion();
var antilope = new Antilope();
var tiger = new Tiger();

var hunters = new List<IHunt>{lion, tiger};
hunters.ForEach(h => h.Hunt());

var runners = new List<IRun>{tiger, antilope};
runners.ForEach(r => r.Run());

var walkers = new List<IWalk>{tiger, antilope, turtle};
walkers.ForEach(w => w.Walk());
