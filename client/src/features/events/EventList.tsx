import {Event} from "../../app/models/event";
import EventCard from "./EventCard";

interface Props{
    events: Event[];
}

export default function EventList({events} : Props){
    return(
        <div className="">
            {events.map(item => (
                <EventCard event={item}/>
            ))}
        </div>
    )
}