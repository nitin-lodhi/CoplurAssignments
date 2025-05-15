import React, { Component } from 'react'
import CourseCard from './CourseCard.jsx';
import Child from './Child.jsx';


const courses = [
  { id: 1, name: "C++", price: 1999 },
  { id: 2, name: "Java", price: 2499 },
  { id: 3, name: "Python", price: 2999 },
  { id: 4, name: "HTML & CSS", price: 999 },
  { id: 5, name: "JavaScript", price: 1999 },
  { id: 6, name: "SQL", price: 1499 },
];

export default class CourseSection extends Component {

    renderData = (data)=> {
        return data.map(course => 
            <CourseCard key={course.id} course = {course} />
        )
    }

  render() {
    return (
      <div>
          <h1>Courses Section</h1>
          
            <Child data={courses} render={this.renderData}/>
          
      </div>
    )
  }
}
