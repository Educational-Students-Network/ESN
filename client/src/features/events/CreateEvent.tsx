import NavBar from "../nav-bar/NavBar";
import plus from "../../img/svg/plus.svg";
import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import agent from "../../app/api/agent";
import axios from "axios";
import { set } from "react-hook-form";

export default function CreateEvent() {
  // const [formData, setFormData] = useState({
  //   title: '',
  //   titlePicture: '', // Assuming you want to store the picture URL
  //   description: '',
  //   date: '',
  //   time: '',
  //   price: 0,
  //   isFree: false,
  //   address: '',
  //   isOnline: false,
  //   link: '',
  //   additionalInfo: '',
  // });
  const [formData, setFormData] = useState({
    Title: '',
    Description: '',
    Time: '',
    Price:'',
    Place: '',
    Link: '',
    Speakers: 'aboba',
    PictureUrl:''
  });
  const [file, setFile] = useState();
  const handleInputChange = (field: string, value: any) => {

    setFormData((prevData) => ({
      ...prevData,
      [field]: value,
    }));
  };

  const handleFileChange = (e: any) => {
    const selectedFile = e.target.files[0];

    setFile(selectedFile);
    if (selectedFile){
      const reader = new FileReader();
      reader.readAsDataURL(selectedFile);
      reader.onloadend = async () => {
        const base64data = reader.result?.toString() || '';
        handleInputChange('PictureUrl', base64data)
      }
    }
  };


  const handleSubmit = async () => {
    // Do something with the collected data (e.g., send it to the server)
    try {
      // if (file) {
      //   const formDataImg = new FormData();
      //   formDataImg.append("file", file);

      //   await axios.post('ImageUpload/upload', formDataImg, {
      //     headers:{
      //       'Content-Type': 'multipart/form-data',
      //     }
      //   }).then((response) => {
      //     // handle the response
      //         //this doesn't save url somehow
      //         console.log(response.data.filePath);
      //         handleInputChange('PictureUrl', response.data.filePath)
              

      //       })
      //       .catch((error) => {
      //         // handle errors
      //         console.log(error);
      //       });
        
      // } else {
      //   // Handle the case where file is undefined
      //   console.error('No file selected');
      // }

      
      agent.Events.createEvent(formData);
      console.log(formData);
      navigate('/');
    } catch (e) {
      console.log('error')
    }
  
  }



  const [page, setPage] = useState(0);
  const navigate = useNavigate();
  
  const getCurrentDate = () => {
    const today = new Date();
    const year = today.getFullYear();
    let month: number | string = today.getMonth() + 1;
    let day: number | string = today.getDate();
  
    // Add leading zeros if needed
    month = month < 10 ? `0${month}` : month;
    day = day < 10 ? `0${day}` : day;
  
    return `${year}-${month}-${day}`;
  };
  
  
  return (
    <div className="page-class">
      <NavBar />
      <div className="createEvent">
        {page === 0 ? (
          <>
            <div className="createEvent__body">
              <span className="createEvent__label">Create Event</span>
              <div className="createEvent__field">
                <h2>Title</h2>
                <div className="createEvent__line"></div>
                <form>
                  <textarea placeholder="Create a title for your event(no more than 50 words )"
                  value={formData.Title}
                  onChange={(e) => handleInputChange('Title', e.target.value)}
                  ></textarea>
                </form>
                <div className="createEvent__line"></div>
                <div className="createEvent__bottom">
                  <img src={plus} alt="plus" />
                  <input type="file" accept="image/*" onChange={handleFileChange} /><h2>Add Picture</h2>
                </div>
              </div>
              <div className="createEvent__field">
                <h2>Description</h2>
                <div className="createEvent__line"></div>
                <form>
                  <textarea placeholder="Create a description for your event(no more than 150 words )"
                  value={formData.Description}
                  onChange={(e) => handleInputChange('Description', e.target.value)}
                  ></textarea>
                </form>
                <div className="createEvent__line"></div>
                <h2>Tags</h2>
              </div>
            </div>
            <div className="createEvent__pagination">
              <div
                onClick={() => {
                  setPage(1);
                }}
              >
                <p className="createEvent__pagination__next">Next</p>
              </div>
              <div
                onClick={() => {
                  navigate("/");
                }}
              >
                <span>Cancel</span>
              </div>
            </div>
          </>
        ) : (
          <>
            <div className="createEvent__body">
              <span className="createEvent__label">Create Event</span>
              <div className="createEvent__field2">
                <div className="createEvent__field2__innerbody">
                  <div className="createEvent__field2__date">
                    <p>Date & Time</p>
                    <input type="date"  id="datePickerId" min={getCurrentDate()}
                    value={formData.Time}
                    onChange={(e) => handleInputChange('Time', e.target.value)}
                    />
                  </div>
                  <div className="createEvent__field2__price">
                    <p>Price</p>
                    <input type="number" 
                    value={formData.Price}
                    onChange={(e) => handleInputChange('Price', parseFloat(e.target.value))}
                    ></input><span className="UAH">UAH</span>
                    <input type="checkbox"></input><span>Free</span>
                  </div>
                  <div className="createEvent__field2__address">
                    <p>Address</p>
                    <input type="text"
                    value={formData.Place}
                    onChange={(e) => handleInputChange('Place', e.target.value)}></input>
                    <input type="checkbox"></input><span>Online</span>
                  </div>
                  <div className="createEvent__field2__link">
                    <p>Link</p>
                    <input ></input>Доробити тут дропдаун і замінити чекбокси
                    <input type="checkbox"></input><span>Online</span>
                  </div>
                </div>
                <div className="createEvent__field2__idk">
                    <p></p>
                    <textarea 
                    value={formData.Link}
                    onChange={(e) => handleInputChange('Link', e.target.value)}></textarea>
                  </div>
                <div className="createEvent__line2"></div>
              </div>
            </div>

            <div className="createEvent__pagination">
              <div
                onClick={handleSubmit}
              >
                <div className="createEvent__submit">Submit</div>
              </div>
              <div
                onClick={() => {
                  navigate("/");
                }}
              >
                <span>Cancel</span>
              </div>
            </div>
          </>
        )}
      </div>
    </div>
  );
}
