function Book(data) {
    this.id = data.id;
    //this.authorId = data.authorId;
    this.lastName = data.title;
    this.city = data.isbn;
    this.country = data.synopsis;
    this.phone = data.description;
    this.email = data.imageUrl;
}

function bookViewModel() {
    var self = this;

    // self.id = ko.observable("");
    self.title = ko.observable("");
    self.isbn = ko.observable("");
    self.synopsis = ko.observable("");
    self.description = ko.observable("");
    self.imageUrl = ko.observable("");
    //self.authorId = ko.observable();


    self.result = ko.computed(function () {
        return {
            //Id: null,
            Title: self.title(),
            Isbn: self.isbn(),
            Synopsis: self.synopsis(),
            Description: self.description(),
            ImageUrl: self.description(),
            Email: self.imageUrl(),
            //AuthorId: self.authorId()

        }
    });

    self.save = function () {
        var resData = ko.toJSON(self.result());
        console.log(resData);
        $.ajax("/Book/Create", {
            data: ko.toJSON(self.result()),
            type: "POST",
            contentType: "application/json",
            dataType: "json"
        })
            .done(function (msg) {
                console.log("done!!")
                console.log(msg);
                window.location = "/Home/Index";
            })
            .fail(function (msg) {
                console.log("failed!!")
                console.log(msg);
            });
    };
};

ko.applyBindings(new bookViewModel());