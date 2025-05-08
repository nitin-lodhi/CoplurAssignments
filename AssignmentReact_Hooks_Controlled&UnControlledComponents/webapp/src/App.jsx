import './App.css'
import EmpUnControlledComponent from './Components/EmpUnControlledComponent.jsx'
import Counter from './Components/Counter.jsx'
import EmpControlledComponent from './Components/EmpControlledComponent.jsx'



function App() {
 
  return (
    <div className='main-container'>
           <Counter/>
           <EmpControlledComponent/>
           <EmpUnControlledComponent/>
    </div>
  )
}

export default App
