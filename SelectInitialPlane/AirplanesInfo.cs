using System;
using System.Collections.Generic;
using System.Text;

namespace SelectInitialPlane
{
    public class AirplanesInfo
    {
        private string _pathAircraftCFG;

        public string PathAircraftCFG
        {
            get { return _pathAircraftCFG; }
            set { _pathAircraftCFG = value; }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _texture;

        public string Texture
        {
            get { return _texture; }
            set { _texture = value; }
        }

        private string _uiType;

        public string UiType
        {
            get { return _uiType; }
            set { _uiType = value; }
        }

        private string _uiVariation;

        public string UiVariation
        {
            get { return _uiVariation; }
            set { _uiVariation = value; }
        }

        private string _uiCreatedby;

        public string UiCreatedby
        {
            get { return _uiCreatedby; }
            set { _uiCreatedby = value; }
        }

        private string _uiTypeRole;

        public string UiTypeRole
        {
            get { return _uiTypeRole; }
            set { _uiTypeRole = value; }
        }

        private string _uiManufacturer;

        public string UiManufacturer
        {
            get { return _uiManufacturer; }
            set { _uiManufacturer = value; }
        }

        private string _atcAirline;

        public string AtcAirline
        {
            get { return _atcAirline; }
            set { _atcAirline = value; }
        }

        private string _atcId;

        public string AtcId
        {
            get { return _atcId; }
            set { _atcId = value; }
        }

        private string _atcFlightNumber;

        public string AtcFlightNumber
        {
            get { return _atcFlightNumber; }
            set { _atcFlightNumber = value; }
        }

        private string _atcParkingCodes;

        public string AtcParkingCodes
        {
            get { return _atcParkingCodes; }
            set { _atcParkingCodes = value; }
        }

        private string _airlineName;

        public string AirlineName
        {
            get { return _airlineName; }
            set { _airlineName = value; }
        }
    }
}
