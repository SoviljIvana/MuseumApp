using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Common
{
    public class Messages
    {
        //museum
        public const string MUSEUM_GET_ALL_ERROR = "Error occured while getting all museums, please try again.";
        public const string MUSEUM_GET_ID_ERROR = "Error occured while getting museum with id: ";

        //auditorium
        public const string AUDITORIUM_GET_ID_ERROR = "Error occured while getting auditorium with id: ";
        public const string AUDITORIUM_GET_ALL_ERROR = "Error occured while getting all auditoriums, please try again.";
        public const string AUDITORIUM_DELETE_ERROR = "Cannot delete autitorium: ";
        public const string AUDITORIUM_NOT_FOUND_ERROR = "Auditorium not found: ";

        //ticket
        public const string TICKET_GET_ALL_ERROR = "Error occured while getting all tickets, please try again.";
        public const string TICKET_GET_ID_ERROR = "Error occured while getting ticket with id: ";

        //user
        public const string USERS_GET_ALL_ERROR = "Error occured while getting all users, please try again.";
        public const string USERS_GET_ID_ERROR = "Error occured while getting user with id: ";

        //exhibition
        public const string EXHIBITIONS_GET_ALL_ERROR = "Error occured while getting all exhibitions, please try again.";
        public const string EXHIBITION_GET_ID_ERROR = "Error occured while getting exhibition with id: ";

        //exhibit
        public const string EXHIBITS_GET_ALL_ERROR = "Error occured while getting all exhibits, please try again.";
        public const string EXHIBIT_GET_ID_ERROR = "Error occured while getting exhibit with id: ";
        public const string EXHIBITS_EMPTY_LIST = "List of exhibits are empty and you can't delete.";
        public const string EXHIBIT_DOES_NOT_LIST = "Does not exist exhibit with this id. ";


        //tag
        public const string TAG_GET_ID_ERROR = "Error occured while getting tag with id: ";
        public const string TAGS_GET_ALL_ERROR = "Error occured while getting all tags, please try again.";




    }
}
