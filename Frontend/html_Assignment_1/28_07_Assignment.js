

function StudentResults()
{

    const Arr = 
[
    {
      "FirstName": "John",
      "LastName": "Doe",
      "Age": 20,
      "Department": "Computer Science"
    },
    {
      "FirstName": "Jane",
      "LastName": "Smith",
      "Age": 22,
      "Department": "Physics"
    },
    {
      "FirstName": "Michael",
      "LastName": "Johnson",
      "Age": 21, 
      "Department": "Mathematics"
    },
    {
      "FirstName": "Sarah",
      "LastName": "Williams",
      "Age": 19,
      "Department": "Computer Science"
    },
    {
      "FirstName": "Robert",
      "LastName": "Brown",
      "Age": 23,
      "Department": "Mathematics"
    },
    {
      "FirstName": "Emily",
      "LastName": "Davis",
      "Age": 20,
      "Department": "Computer Science"
    }
]


const studentsDep = Arr.filter(student => student.Department === "Computer Science");
console.log(studentsDep);

const studentGreater21 = Arr.filter(student => student.Age > 21);
console.log(studentGreater21);

const NameRobert = Arr.some(student => student.FirstName === "Robert" );
console.log(NameRobert);

const AgeAbove23 = Arr.some(student => student.Age >23 );
console.log(AgeAbove23);


const everyAbove18 = Arr.every(student => student.Age > 18 );
console.log(everyAbove18);


const JohnDepartment = Arr.filter(student => student.FirstName === "John");
const Dep = JohnDepartment.find(student => student.Department);
console.log(Dep["Department"]);


}