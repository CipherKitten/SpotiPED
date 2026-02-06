# SpotiPED
EPED Spotify.

# Folders
Some folders whose purpose is not entirely clear

<details>
  <summary>wwwroot/imgs/pfps/</summary>

  ### What is it?
   The folder that contains the profile pictures
  
  ### Format:
   [username][uuid].[image extension]
</details>

# Data Models (DB)

<details>
  <summary>User</summary>

  ### Attributes
  - Id

      | Characteristic | Value |
      | --- | --- |
      | Type | String |
      | Content | GUID |
      | Attrubute Type | Primary Key |
        
  - Email

      | Characteristic | Value |
      | --- | --- |
      | Type | String |
      | Attrubute Type | Unique |
  
  - PasswordHash

      | Characteristic | Value |
      | --- | --- |
      | Type | String |
      | Content | Password Hash |
      | Hash Type | TO DECIDE |

  - PasswordSalt

      | Characteristic | Value |
      | --- | --- |
      | Type | String |
      | Content | Hash Salt |
      | Salt Type | TO DECIDE |

  - Name

      | Characteristic | Value |
      | --- | --- |
      | Type | String |

  - DateOfBirth

      | Characteristic | Value |
      | --- | --- |
      | Type | DateTime |

  - ThemeId

      | Characteristic | Value |
      | --- | --- |
      | Type | int |
      | Attrubute Type | Foreign Key (Theme) |

  - CreatedAt

      | Characteristic | Value |
      | --- | --- |
      | Type | DateTime |
      | Content | Date and time of the account’s creation |

  - UpdatedAt

      | Characteristic | Value |
      | --- | --- |
      | Type | DateTime |
      | Content | Date and time of the accoun's last update |
</details>

<details>
  <summary>Theme</summary>

  ### Attributes
   - Id

      | Characteristic | Value |
      | --- | --- |
      | Type | int |
      | Attrubute Type | Primary Key |
        
  - Name

      | Characteristic | Value |
      | --- | --- |
      | Type | String |
      | Content | Name of the theme |
  
  - PrimaryHex

      | Characteristic | Value |
      | --- | --- |
      | Type | String |
      | Content | The hex code for the primary color |

  - SecondaryHex

      | Characteristic | Value |
      | --- | --- |
      | Type | String |
      | Content | The hex code for the secondary color |

  - TextHex

      | Characteristic | Value |
      | --- | --- |
      | Type | String |
      | Content | The hex code for the text color |

  </details>

<details>
  <summary>SpotifyToken</summary>

  ### Attributes
  - Id

      | Characteristic | Value |
      | --- | --- |
      | Type | String |
      | Content | GUID |
      | Attrubute Type | Primary Key |
        
  - UserId

      | Characteristic | Value |
      | --- | --- |
      | Type | String |
      | Content | GUID |
      | Attrubute Type | Foreign Key (User) |
  
  - AccessToken

      | Characteristic | Value |
      | --- | --- |
      | Type | String |

  - RefreshToken

      | Characteristic | Value |
      | --- | --- |
      | Type | String |

  - ExpiresIn

      | Characteristic | Value |
      | --- | --- |
      | Type | DateTime |
      | Content | When the AccessToken will expire (UTC)| 
</details>

<details>
  <summary>Favorite</summary>

  ### Attributes
  - Id

      | Characteristic | Value |
      | --- | --- |
      | Type | String |
      | Content | GUID |
      | Attrubute Type | Primary Key |
        
  - UserId

      | Characteristic | Value |
      | --- | --- |
      | Type | String |
      | Content | GUID |
      | Attrubute Type | Foreign Key (User) & Primary|
  
  - SpotifyItemId

      | Characteristic | Value |
      | --- | --- |
      | Type | String |
      | Content | The Id for a spotify item (eg: song) |

  - Type

      | Characteristic | Value |
      | --- | --- |
      | Type | Enum |
      | Content | Type of spotify item |
      | Enum Options | Track; Playlist; Podcast; Album |

  - CreatedAt

      | Characteristic | Value |
      | --- | --- |
      | Type | DateTime |
      | Content | Date and time the item was added |

</details>

<details>
  <summary>AuditLog</summary>

  ### Attributes
  - Id

      | Characteristic | Value |
      | --- | --- |
      | Type | String |
      | Content | GUID |
      | Attrubute Type | Primary Key |
        
  - UserId

      | Characteristic | Value |
      | --- | --- |
      | Type | String |
      | Content | GUID |
      | Attrubute Type | Foreign Key (User) |
  
  - Event

      | Characteristic | Value |
      | --- | --- |
      | Type | String |
      | Content | What Happened |

  - Detail

      | Characteristic | Value |
      | --- | --- |
      | Type | String |
      | Content | Details of what happened |

  - CreatedAt

      | Characteristic | Value |
      | --- | --- |
      | Type | DateTime |
      | Content | Date and time the event happened |

</details>
