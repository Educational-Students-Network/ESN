

interface Props{
    events: Event[];
}

export default function EventList({events}: Props){
    return(
        <>
            {events.map(event => {
                <p></p>
            })}
        </>
    )
}