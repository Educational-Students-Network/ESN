import {Event} from "../../app/models/event";
import EventCard from "./EventCard";

interface Props{
    events: Event[];
}

export default function EventList({events} : Props){
    return(
        <div className="">
<<<<<<< HEAD
            {events.map((item, index) => (
                <EventCard key={index} event={item}/>
=======
            {events.map(item => (
                <EventCard event={item}/>
>>>>>>> 95e8f6d94275e0d193004a8a0340148a48ca3370
            ))}
        </div>
    )
}