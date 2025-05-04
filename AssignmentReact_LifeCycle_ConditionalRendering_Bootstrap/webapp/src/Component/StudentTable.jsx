import React from 'react'
// import './StudentTable.css'
import Fail from './Fail'
import Pass from './Pass'

const StudentTable = (props) => {

    const studentsData = props.studentsData

    const list = studentsData.map((student) => {
        return (

            <tr key={student._id}>
                <td>{student.name}</td>
                <td>{student.math}</td>
                <td>{student.science}</td>
                <td>{student.english}</td>
                <td>{student.math + student.science + student.english}</td>
                <td>{((student.math + student.science + student.english) / 3).toFixed(2)} %</td>
                <td>{(student.math >= 33 && student.science >= 33 && student.english >= 33) ? <Pass /> : <Fail />}</td>
            </tr>

        )
    })

    return (
        <div>
            <h1 id='table-name'>Students Data</h1>
            <table className="table table-hover">
                <thead>
                    <tr>
                        <th scope="col">Name</th>
                        <th scope="col">Maths</th>
                        <th scope="col">Science</th>
                        <th scope="col">English</th>
                        <th scope="col">Total</th>
                        <th scope="col">Percentage</th>
                        <th scope="col">Pass/Fail</th>
                    </tr>
                </thead>
                <tbody>
                    {list}
                </tbody>
            </table>
        </div>
    )
}

export default StudentTable