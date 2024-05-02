using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitedScenes : MonoBehaviour
{
    public bool visitedGallery = false;
    public bool visitedPeasant = false;
    public bool visitedLightToDark = false;
    public bool visitedFrance = false;
    public bool visitedHospitalOUTDOORS = false;
    public bool visitedHospitalINDOORS = false;
    public bool visitedFinalMoments = false;

    public void setGallery(){
        visitedGallery = true;
    }
    public void setPeasant(){
        visitedPeasant = true;
    }
    public void setLightToDark(){
        visitedLightToDark = true;
    }
    public void setFrance(){
        visitedFrance = true;
    }
    public void setHospitalOUTDOORS(){
        visitedHospitalOUTDOORS = true;
    }
    public void setHospitalINDOORS(){
        visitedHospitalINDOORS = true;
    }
    public void setFinalMoments(){
        visitedFinalMoments = true;
    }
}
