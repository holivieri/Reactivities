import { useEffect, useState } from 'react'
import './App.css'

function App() {
  const [activities, setActivities] = useState<Activity[]>([]);

  useEffect(() => {
    fetch('https://localhost:5001/api/activities')
      .then(response => response.json())
      .then(data => setActivities(data))

      return () => {}
  }, []);

  return (
    <div>
        <h3 className='App' style={{color: 'orange'}}>Reactivities</h3>
        <ul>
          {activities.map((activity) => (
            <li key={activity.id}>{activity.title}</li>
          ))}
        </ul>
    </div>
  )
}

export default App
