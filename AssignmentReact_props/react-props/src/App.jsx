import './App.css'
import StudentTable from './Component/StudentTable'

function App() {

  const studentsData = [
    {"name": "Aarav", "math": 85, "science": 90, "english": 88},
    {"name": "Ananya", "math": 78, "science": 82, "english": 75},
    {"name": "Vivaan", "math": 92, "science": 88, "english": 91},
    {"name": "Diya", "math": 70, "science": 75, "english": 80},
    {"name": "Rohan", "math": 88, "science": 92, "english": 86},
    {"name": "Meera", "math": 60, "science": 65, "english": 70},
    {"name": "Arjun", "math": 95, "science": 94, "english": 93},
    {"name": "Kavya", "math": 82, "science": 79, "english": 85},
    {"name": "Yash", "math": 76, "science": 80, "english": 78},
    {"name": "Isha", "math": 89, "science": 91, "english": 87},
]


  return (
    <>
        <StudentTable studentsData = {studentsData} />
    </>
  )
}

export default App
