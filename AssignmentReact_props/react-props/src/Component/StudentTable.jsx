import React from 'react'
import './StudentTable.css'

const StudentTable = (props) => {

    const studentsData = props.studentsData

    const list = studentsData.map((student) => {

        const name = student.name;
        const math = student.math;
        const science = student.science;
        const english = student.english;
        const total = math + science + english;
        const percentage = (total/3).toFixed(2);

        return (
           <tr>
                <td>{name}</td>
                <td>{math}</td>
                <td>{science}</td>
                <td>{english}</td>
                <td>{total}</td>
                <td>{percentage}%</td>
           </tr>
        )
    })

    return (
        <div>
            <h1 id='table-name'>Students Data</h1>
            <table>
                <tr>
                    <th>Name</th>
                    <th>Math</th>
                    <th>Science</th>
                    <th>English</th>
                    <th>Total</th>
                    <th>Percentage</th>
                </tr>
                {list}
            </table>
        </div>
    )
}

export default StudentTable