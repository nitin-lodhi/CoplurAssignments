import React, { useEffect, useState } from 'react'

const Counter = () => {

    const [count,setCount] = useState(0);

    useEffect(()=> {
       let timer = setTimeout(()=>{
           setCount(count+1)
        },5000)
        return ()=> clearTimeout(timer)
    },[count])

  return (
    <div>
          <h1>Count : {count}</h1>
    </div>
  )
}

export default Counter