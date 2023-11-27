import NavBar from "../nav-bar/NavBar";
import { Event } from "../../app/models/event";
import EventList from "./EventList";
import { useEffect, useState } from "react";
import agent from "../../app/api/agent";



export default function Events() {

  const [events, setEvents] = useState<Event[]>([])


  useEffect(() => {
    agent.Events.allEvents().then(events => setEvents(events))
<<<<<<< HEAD
  })
=======
  },[])
>>>>>>> 95e8f6d94275e0d193004a8a0340148a48ca3370


  return (
    <>
      <div className="page-class">
        <NavBar />
        <div className="event-list">
          <EventList events={events} />
        </div>
      </div>
    </>
  );
}
