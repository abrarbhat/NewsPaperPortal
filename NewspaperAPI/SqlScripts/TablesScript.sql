
Create database NewspaperPortalDB;

use NewspaperPortalDB;

CREATE TABLE Articles (
  [id] int  IDENTITY(1,1) PRIMARY KEY,
  [sefurl] varchar(max)   NULL,
  [title] varchar(max)   NULL,
  [definition] varchar(max)   NULL,
  [img] varchar(max)   NULL,
  [catid] int   NULL,
  [authorid] int   NULL,
  [summary] varchar(max)   NULL,
  [article] varchar(max)   NULL,
  [tags] varchar(max)   NULL,
  [allowcomm] int   NULL,
  [voteup] int   NULL,
  [votedown] int   NULL,
  [statu] int   NULL,
  [insertdt] varchar(max)   NULL,
  [ip] varchar(max)   NULL,
  [log] varchar(max)   NULL,
  [updatedt] varchar(max)   NULL,
  [updaterip] varchar(max)   NULL,
  [updatedlog] varchar(max)   NULL
)  ;


CREATE TABLE Author (
  [id] int  IDENTITY(1,1) PRIMARY KEY,
  [img] varchar(max)   NULL,
  [name] varchar(max)   NULL,
  [surname] varchar(max)   NULL,
  [email] varchar(max)   NULL,
  [pass] varchar(max)   NULL,
  [birthday] varchar(max)   NULL,
  [from] varchar(max)   NULL,
  [lives] varchar(max)   NULL,
  [sex] varchar(max)   NULL,
  [statu] int   NULL,
  [hit] int   NULL,
  [type] int   NULL,
  [regdt] varchar(max)   NULL,
  [regip] varchar(max)   NULL,
  [reglog] varchar(max)   NULL,
  [updatedt] varchar(max)   NULL,
  [updater] varchar(max)   NULL,
  [updaterip] varchar(max)   NULL
)  ;

CREATE TABLE Categor (
  [id] int   IDENTITY(1,1) PRIMARY KEY,
  [sefurl] varchar(max)   NULL,
  [catname] varchar(max)   NULL,
  [catdetail] varchar(max)   NULL,
  [catimg] varchar(max)   NULL,
  [upcatid] int   NULL,
  [cattype] varchar(max)   NULL,
  [statu] int   NULL,
  [createddt] varchar(max)   NULL,
  [creator] varchar(max)   NULL,
  [creatorip] varchar(max)   NULL,
  [updateddt] varchar(max)   NULL,
  [updaterip] varchar(max)   NULL,
  [updater] varchar(max)   NULL
)  ;

CREATE TABLE Comments (
  [id] int  IDENTITY(1,1) PRIMARY KEY,
  [commtype] varchar(max)   NULL,
  [dataid] int   NULL,
  [answer] int   NULL,
  [userid] int   NULL,
  [fullname] varchar(max)   NULL,
  [nick] varchar(max)   NULL,
  [email] varchar(max)   NULL,
  [hideemail] int   NULL,
  [title] varchar(max)   NULL,
  [comment] varchar(max)   NULL,
  [positive] int   NULL,
  [negative] int   NULL,
  [avatar] varchar(max)   NULL,
  [date] varchar(max)   NULL,
  [ip] varchar(225)   NULL,
  [deletdt] varchar(max)   NULL,
  [deleter] varchar(max)   NULL,
  [updatedt] varchar(225)   NULL,
  [updaterip] varchar(225)   NULL,
  [statu] int   NULL
)  ;


CREATE TABLE News (
  [id] int   IDENTITY(1,1) PRIMARY KEY,
  [sefurl] varchar(max)   NULL,
  [title] varchar(max)   NULL,
  [summary] varchar(max)   NULL,
  [news] varchar(max)   NULL,
  [hits] int   NULL,
  [comment] int   NULL,
  [breakingnews] int   NULL,
  [headline] int   NULL,
  [newsorder] int   NULL,
  [tags] varchar(max)   NULL,
  [catid] int   NULL,
  [img] varchar(max)   NULL,
  [breakingimg] varchar(max)   NULL,
  [description] varchar(max)   NULL,
  [date] varchar(max)   NULL,
  [ip] varchar(max)   NULL,
  [browser] varchar(max)   NULL,
  [location] varchar(max)   NULL,
  [timezone] varchar(max)   NULL,
  [statu] int   NULL,
  [who] varchar(max)   NULL,
  [updatedt] varchar(max)   NULL,
  [updaterip] varchar(max)   NULL,
  [deldt] varchar(max)   NULL,
  [whodeleted] varchar(max)   NULL,
  [dtrip] varchar(max)   NULL,
  [deleted] int   NULL
)  ;


CREATE TABLE Setting (
  [id] int  IDENTITY(1,1) PRIMARY KEY,
  [sitename] varchar(max)   NULL,
  [url] varchar(max)   NULL,
  [title] varchar(max)   NULL,
  [copy] varchar(max)   NULL,
  [analytics] varchar(max)   NULL,
  [statu] int   NULL,
  [mail] varchar(max)   NULL,
  [mailhost] varchar(max)   NULL,
  [mailport] varchar(max)   NULL,
  [mailuser] varchar(max)   NULL,
  [mailpassword] varchar(max)   NULL,
  [repmail] varchar(max)   NULL,
  [login] int   NULL,
  [reg] int   NULL,
  [regtype] int   NULL,
  [advertbox] int   NULL,
  [ ice] int   NULL,
  [manset] int   NULL,
  [manset2] int   NULL,
  [flas] int   NULL,
  [updater] int   NULL,
  [updatedt] varchar(max)   NULL,
  [updaterip] varchar(max)   NULL
)  ;


CREATE TABLE Tags (
  [id] int    NULL,
  [name] varchar(max)   NULL,
  [hit] int   NULL,
  [statu] int   NULL,
  [createdt] varchar(max)   NULL,
  [creator] varchar(max)   NULL,
  [creatorip] varchar(max)   NULL,
  [updatedt] varchar(max)   NULL,
  [updater] varchar(max)   NULL,
  [updaterip] varchar(max)   NULL,
  [sefurl] varchar(max)   NULL
)  ;


CREATE TABLE Team (
  [id] int IDENTITY(1,1) PRIMARY KEY,
  [fullname] varchar(225)   NULL,
  [email] varchar(max)   NULL,
  [pass] varchar(max)   NULL,
  [birddy] date   NULL,
  [from] varchar(225)   NULL,
  [lives] varchar(225)   NULL,
  [regdt] datetime2(0)   NULL,
  [regip] varchar(max)   NULL,
  [lastlog] datetime2(0)   NULL,
  [lastip] varchar(max)   NULL,
  [type] varchar(max)   NULL,
  [statu] int   NULL,
  [per] varchar(max)   NULL
)  ;

CREATE TABLE Users (
  [id] int IDENTITY(1,1) PRIMARY KEY,
  [name] varchar(max)   NULL,
  [surname] varchar(max)   NULL,
  [nick] varchar(max)   NULL,
  [email] varchar(max)   NULL,
  [pass] varchar(max)   NULL,
  [forgot] int   NULL,
  [forgotpass] varchar(max)   NULL ,
  [forgotpassdt] varchar(max)   NULL,
  [forgotpassip] varchar(max)   NULL,
  [passeddt] varchar(max)   NULL,
  [passedip] varchar(max)   NULL,
  [dt] varchar(max)   NULL,
  [dy] varchar(max)   NULL,
  [statu] int   NULL,
  [sex] int   NULL,
  [acctype] varchar(max)   NULL,
  [acstatu] int   NULL,
  [regdate] varchar(max)   NULL,
  [registerip] varchar(max)   NULL,
  [regkey] varchar(max)   NULL,
  [activationdt] varchar(max)   NULL,
  [activatorip] varchar(max)   NULL,
  [regkeystatu] int   NULL,
  [lastlogindt] varchar(max)   NULL,
  [lastip] varchar(max)   NULL
)  ;

CREATE TABLE Video (
  [id] int   IDENTITY(1,1) PRIMARY KEY,
  [title] varchar(max)   NULL,
  [description] varchar(max)   NULL,
  [poster] varchar(max)   NULL,
  [url] varchar(max)   NULL,
  [type] varchar(max)   NULL,
  [catid] int   NULL,
  [date] datetime2(0)   NULL,
  [hit] int   NULL,
  [like] int   NULL,
  [dislike] int   NULL,
  [who] varchar(max)   NULL,
  [ip] varchar(max)   NULL,
  [updatedt] varchar(max)   NULL,
  [updaterip] varchar(max)   NULL,
  [tags] varchar(max)   NULL,
  [newsid] int   NULL,
  [statu] int   NULL
)  ;







