import React, { useRef } from 'react'
import './Emp.css'

const EmpUnControlledComponent = () => {

    const nameRef = useRef("");
    const emailRef = useRef("");
    const deptRef = useRef("");

    const handleSubmit = async (e) => {
        e.preventDefault()
        alert(` User details => Name: ${nameRef.current.value}, Email: ${emailRef.current.value}, Dept: ${deptRef.current.value}.`)
        nameRef.current.value = "";
        emailRef.current.value = "";
        deptRef.current.value = "";
    }


    return (
        <div>
            <h2>Uncontrolled Component</h2>
            <form onSubmit={handleSubmit}>
                <div>
                    <label htmlFor="name">Name</label>
                    <input type="text" name='name' id="name" placeholder='Enter your name...' required autoComplete='off'
                        ref={nameRef}
                    />
                </div>
                <div>
                    <label htmlFor="email">Email</label>
                    <input type="email" name='email' id="email" placeholder='Enter your email...' required autoComplete='off'
                        ref={emailRef}
                    />
                </div>
                <div>
                    <label htmlFor="dept">Department</label>
                    <input type="text" name='dept' id="dept" placeholder='Enter your department...' required autoComplete='off'
                        ref={deptRef}
                    />
                </div>
                <button type='submit'>Submit</button>
            </form>
        </div>
    )
}

export default EmpUnControlledComponent
