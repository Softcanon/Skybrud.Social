﻿namespace Skybrud.Social.Facebook.Enums {
    
    public enum FacebookPrivacy {

        /// <summary>
        /// Uses the privacy value granted to the app in the Login Dialog.
        /// </summary>
        Default,
        
        /// <summary>
        /// Everyone will be able to see the album.
        /// </summary>
        Everyone,

        /// <summary>
        /// Friends of the user will be able to see the album.
        /// </summary>
        AllFriends,
        
        /// <summary>
        /// Friends of the friends of the user will be able to see the album.
        /// </summary>
        FriendsOfFriends,

        Custom,

        /// <summary>
        /// Only the user will be able to see the album.
        /// </summary>
        Self
    
    }

}
