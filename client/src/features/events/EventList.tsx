import { Event } from "../../app/models/event";
import EventCard from "./EventCard";
import sad from '../../img/png/sad.png'

interface Props {
  events: Event[];
}

export default function EventList({ events }: Props) {
  return (
    <div className="eventlist">
      <div className="">
        {events.map((item, index) => (
          <EventCard key={index} event={item} />
        ))}
      </div>
      <div className="eventlist__line" />
      <div className="eventlist__noevents flexCenter">
        <h1>Thats all for now!</h1>
      </div>
    </div>
  );
}
