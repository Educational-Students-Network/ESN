import { Event } from "../../app/models/event";
import "../../styles/style.css";
interface Props {
  event: Event;
}

export default function EventCard({ event }: Props) {
  return (
    <div className="event">
      <div className="header">
        <p>Logo</p>
        <p>{event.authorUsername}</p>
      </div>
      <img src={event.pictureUrl} alt="banner" />
      <div className="description">
        <div className="time-place-speakers">
          <div className="date-place">
            <p>Дата та час: {event.time}</p>
            <p>Місце проведення: {event.place}</p>
          </div>

          <div className="speakers">
            <p>Головні спікери</p>
            <ul>
              {event.speakers.split(", ").map((item, index) => (
                <li key={index}>{item}</li>
              ))}
            </ul>
          </div>
        </div>
        <div className="event-description">
          <p>Опис події:</p>
          <p>{event.description}</p>
        </div>
      </div>
      <div className="reactions">
        <p>Like</p>
        <p>Comment</p>
        <p>Repost</p>
      </div>
    </div>
  );
}
