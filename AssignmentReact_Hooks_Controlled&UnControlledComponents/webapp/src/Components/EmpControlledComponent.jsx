import React, { useState } from 'react'
import './Emp.css'

const EmpControlledComponent = () => {
  const [user, setUser] = useState({
    name: "",
    email: "",
    dept: ""
  })

  const handleInput = (e) => {
    // console.log(e.target.name);
    // console.log(e.target.value);
    let name = e.target.name
    let value = e.target.value
    setUser({
      ...user,
      [name]: value
    })
  }

  const handleSubmit = async (e) => {
    e.preventDefault()
    // console.log("User : ", user)
    alert(` User details => Name: ${user.name}, Email: ${user.email}, Dept: ${user.dept}.`)
    setUser({
      name: "",
      email: "",
      dept: ""
    })
  }

  return (
    <div>
      <h2>Controlled Component</h2>
      <form onSubmit={handleSubmit}>
        <div>
          <label htmlFor="name">Name</label>
          <input type="text" name='name' id="name" placeholder='Enter your name...' required autoComplete='off'
            value={user.name}
            onChange={handleInput}
          />
        </div>
        <div>
          <label htmlFor="email">Email</label>
          <input type="email" name='email' id="email" placeholder='Enter your email...' required autoComplete='off'
            value={user.email}
            onChange={handleInput}
          />
        </div>
        <div>
          <label htmlFor="dept">Department</label>
          <input type="text" name='dept' id="dept" placeholder='Enter your department...' required autoComplete='off'
            value={user.dept}
            onChange={handleInput}
          />
        </div>
        <button type='submit'>Submit</button>
      </form>
    </div>
  )
}

export default EmpControlledComponent
