function movies()
{
    const Arr = [
        {
          "MovieName": "The Great Adventure",
          "ActorName": "John Smith",
          "ReleaseDate": "2023-01-15"
        },
        {
          "MovieName": "Mystery in the Woods",
          "ActorName": "Emily Johnson",
          "ReleaseDate": "2022-09-28"
        },
        {
          "MovieName": "Love and Destiny",
          "ActorName": "Michael Brown",
          "ReleaseDate": "2023-05-02"
        },
        {
          "MovieName": "City of Shadows",
          "ActorName": "Sophia Williams",
          "ReleaseDate": "2023-03-12"
        },
        {
          "MovieName": "The Last Stand",
          "ActorName": "William Davis",
          "ReleaseDate": "2022-11-07"
        },
        {
          "MovieName": "Echoes of Time",
          "ActorName": "Olivia Wilson",
          "ReleaseDate": "2022-12-19"
        }
      ]
      console.log("Answer of 1st question");
//1. List the movie name along with the actor name of those movies released in the year 2022
    const movieIn2022 = Arr.filter(movie => movie.ReleaseDate > '2022-01-01' && movie.ReleaseDate < '2023-01-01').map(movie => ({
    MovieName: movie.MovieName,
    ActorName: movie.ActorName
    })
    );
    movieIn2022.forEach(element => { console.log("Movie name:"+element.MovieName + ","+"actorname:" +element.ActorName)
    });

    
//2. List the movie names released in the year 2023 where the actor is William Davis.
    console.log("Answer of 2nd question");

    const movieIn2023WithWilliam = Arr.filter(movie => movie.ReleaseDate >= '2023-01-01' && movie.ReleaseDate < '2024-01-01' && movie.ActorName == "William Davis").map(movie =>({
      movieIn2023WithWilliamMovieName: movie.MovieName
    }));


    movieIn2023WithWilliam.forEach(element => { console.log("Movie name:"+element.MovieName)
    });


    //const actor =  Arr.find(element => element.ActorName ==="The Last Stand")
    //console.log(actor);
  
//3. Retrieve the Actor name and release date of the movie “The Last Stand"

    console.log("Answer of 3rd question");


    const lastMovie = Arr.find(element => element.MovieName === "The Last Stand");
    console.log(lastMovie.ActorName + ", Release Date:" + lastMovie.ReleaseDate);

//4.Check whether there is any movie in the list with actor name “John Doe”
    
    console.log("Answer of 4th question");
    const JohnDoe = Arr.filter(element => element.ActorName == "John Doe");
    console.log(JohnDoe);

//5. Display the count of movies where the actor name is "Sophia Williams"

console.log("Answer of 5th question");
    const sophiaWilliams = Arr.filter(element => element.ActorName == "Sophia Williams");
    console.log("count of movies where the actor name is Sophia Williams: " + sophiaWilliams.length);



   

//6. Insert an element at last

console.log("Answer of 6th question");

    Arr.push({
      "MovieName": "The Final Stage",
      "ActorName": "John Doe",
      "ReleaseDate": "2022-08-11"
  });

  console.log(Arr);

//8. Create a new array starting from the movie "City of Shadows"

console.log("Answer of 8th question");
console.log(Arr.findIndex(x => x.MovieName === "City of Shadows"));

  const newArray = Arr.slice((Arr.findIndex(x => x.MovieName === "City of Shadows")));
  console.log(newArray);




//10. Insert an element as next 


console.log("Answer of 10th question");
var indexOfLOD = Arr.findIndex(x => x.MovieName === "Love and Destiny");
console.log(indexOfLOD);
    Arr.splice(indexOfLOD+1,	0,{
      "MovieName": "Rich & Poor",
      "ActorName": "Johnie Walker",
      "ReleaseDate": "2023-08-11"
  });
  console.log(Arr);

//12. Insert an element as next 
/*console.log("Answer of 12th question");
var indexOfElement = Arr.findIndex(x => x.MovieName === "The Last Stand");
console.log(indexOfElement);
    Arr.splice(indexOfElement,1);
    console.log(Arr);*/


//11.Display the count of distinct actor names in array
  console.log("Answer of 11th question");
  const distinctActor = new Set(Arr.map(movie => movie.ActorName));
  console.log(distinctActor);

//14. Update movie named  "City of Shadows" ‘s release date as  "2023-03-13"
console.log("Answer of 14th question");
  var movieIndex = Arr.findIndex(movie => movie.MovieName === "City of Shadows");
  Arr[movieIndex].ReleaseDate = "2023-03-13";
  console.log("Changed Date of movie City of Shadows is, " + Arr[movieIndex].ReleaseDate);


//15. Create a new array of movie names whose movie name length is greater than 10.
  console.log("Answer of 15th question");
  const GreaterThan10 = Arr.filter(movie => movie.MovieName.length > 10).map(movie => movie.MovieName);
  console.log(GreaterThan10);



 


    


    
    
  

}