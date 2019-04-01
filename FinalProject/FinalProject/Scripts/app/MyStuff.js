var numRowsGlobal = 0;

function ViewModel() {
    //These knockout observable variables are bound to HTML elements, which means
    //their values are updated every time a change is made to the bound HTML elements

    this.name = ko.observable("");
    this.addTitle = ko.observable("");
    this.addArtist = ko.observable("");
    this.addGenre = ko.observable("");

    this.names = ko.observableArray([]);
    this.titles = ko.observableArray([]);
    this.artists = ko.observableArray([]);
    this.genres = ko.observableArray([]);

    this.name.subscribe(function (name) {
        document.getElementById("favorite").innerHTML = name + ("'s Favorite Music:");
    });

    this.addItem = function () { //defines and creates instance of a the addItem function within the scope of ViewModel()
        this.names.push(this.name());
        if (this.name() != "") {
            this.titles.push(this.addTitle); //Add new music data to respective lists
            this.artists.push(this.addArtist);
            this.genres.push(this.addGenre);
            var length = this.titles().length;
            updateTable(this.name(), this.addTitle(), this.addArtist(), this.addGenre(), length);//Calls function to update table
            
            this.addTitle(""); //Removes previously entered text from text boxes
            this.addArtist("");
            this.addGenre("");

            test
        }
    }
}

var test = $('#deleteSelected').click(function () {
    var idSelector = function () { return this.id; };
    var thing = $("input:checked").map(idSelector).get();

    var rowId = "row";
    deleteNum = thing.length;
    for (var i = 0; i < deleteNum; i++) {
        rowId = "#row";
        rowId += thing[i];
        $(rowId).remove();
    }
});

function updateTable(name, title, artist, genre, listLength) {
    var tbl = document.getElementById('MusicTable') //Finds table
    var row = document.createElement("tr"); //Creates new row
    row.className = name;
    var column1 = document.createElement("td");//Creates three new columns
    var column2 = document.createElement("td");
    var column3 = document.createElement("td");
    var column4 = document.createElement("td");

    column1.appendChild(document.createTextNode(title)); //Adds text node with title to column
    row.appendChild(column1); //Add column to row
    column2.appendChild(document.createTextNode(artist));
    row.appendChild(column2);
    column3.appendChild(document.createTextNode(genre));
    row.appendChild(column3);
    numRowsGlobal++;
    row.id = "row" + numRowsGlobal.toString();
    row.setAttribute("name", "rower");
    var button = document.createElement("input");
    button.id = numRowsGlobal.toString();
    button.setAttribute("type", "checkbox");
    column4.appendChild(button);
    row.appendChild(column4);

    tbl.appendChild(row); //Adds row with columns to table
    //document.getElementById(button.id).innerHTML = "Delete";

}


// Activates knockout.js
ko.applyBindings(new ViewModel());