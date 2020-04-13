Use NewspaperPortalDB;

INSERT INTO Categor ([id], [sefurl], [catname], [catdetail], [catimg], [upcatid], [cattype], [statu], [createddt], [creator], [creatorip], [updateddt], [updaterip], [updater]) VALUES
(1, '', 'Haberler', 'Haber kategorileri  ', ' http://vukuat.com/upload/images/news/03-06-2014/03-06-2014_vukuat.com_kara-sahin-somali_9782.jpg', 0, 'news', 1, '20-06-2014 02:27:57', '', '46.197.37.1', '21-06-2014 15:16:49', '46.197.37.1', ''),
(2, 'gundem', 'Gündem', 'Gündem', 'g', 1, 'news', 1, '20-06-2014 02:28:26', '', '46.197.37.1', '21-06-2014 00:45:32', '46.197.37.1', ''),
(3, '', 'Sağlık', 'Sağlık', 's', 1, 'news', 0, '20-06-2014 02:28:44', '', '46.197.37.1', '', '', ''),
(4, '', 'Eğitim', 'Eğitim haberleri', 'e', 1, 'news', 0, '20-06-2014 02:29:13', '', '46.197.37.1', '', '', ''),
(5, '', 'Ekonomi', '', 'https://cdn3.iconfinder.com/data/icons/banking-icons/32/Graph-512.png', 1, 'news', 1, '20-06-2014 02:32:36', '', '46.197.37.1', '20-06-2014 03:28:15', '46.197.37.1', ''),
(6, '', 'Finans', 'Finans haberleri.', 'Finans', 1, 'news', 0, '20-06-2014 02:33:31', '', '46.197.37.1', '', '', ''),
(7, '', 'Hava', 'Hava koşulları Hava durumları ile ilgili kategori', 'Hava ', 1, 'news', 0, '20-06-2014 02:35:23', '', '46.197.37.1', '', '', ''),
(8, '', 'Yerel', 'Yerel haberler.', 'yerel', 0, 'news', 1, '20-06-2014 02:37:16', '', '46.197.37.1', '20-06-2014 03:03:29', '46.197.37.1', ''),
(9, '', 'İstanbul', 'İstanbul yerel haberler kategorisi', 'istanbul', 8, 'news', 1, '20-06-2014 02:37:55', '', '46.197.37.1', '20-06-2014 03:01:43', '46.197.37.1', ''),
(10, '', 'Ankara', 'Ankara yerel haberler kategorisi', 'ankara', 8, 'news', 1, '20-06-2014 02:38:13', '', '46.197.37.1', '20-06-2014 03:02:37', '46.197.37.1', ''),
(11, '', 'İzmir', 'İzmir yerel haberler kategorisi', 'izmir', 8, 'news', 1, '20-06-2014 02:38:34', '', '46.197.37.1', '20-06-2014 03:02:19', '46.197.37.1', ''),
(12, '', 'Diyarbakır', 'Diyarbakır yerel haberler kategorisi', 'Diyarbakır', 8, 'news', 1, '20-06-2014 02:43:07', '', '46.197.37.1', '20-06-2014 03:01:29', '46.197.37.1', ''),
(13, '', 'Son dakika', 'Sondakika haberleri.', 'sondakika', 1, 'news', 1, '20-06-2014 03:04:35', '', '46.197.37.1', '', '', ''),
(14, 'politika.html', 'Politika', 'Politika', 'politika', 1, 'news', 1, '20-06-2014 03:06:54', '', '46.197.37.1', '21-06-2014 14:52:45', '46.197.37.1', ''),
(17, '', 'Haberler', 'ss', 's', 0, 'news', 1, '21-06-2014 15:17:11', '', '46.197.37.1', '', '', ''),
(15, 'haberler.html', 'Haberler', 'dwad', 'daw', 0, 'news', 1, '21-06-2014 15:10:08', '', '46.197.37.1', '', '', ''),
(16, 'haberler.html', 'haberler', 'dwad', 'dwa', 1, 'news', 1, '21-06-2014 15:12:30', '', '46.197.37.1', '', '', '');



INSERT INTO Setting ([id], [sitename], [url], [title], [copy], [analytics], [statu], [mail], [mailhost], [mailport], [mailuser], [mailpassword], [repmail], [login], [reg], [regtype], [advertbox], [manset], [manset2], [flas], [updater], [updatedt], [updaterip]) VALUES
(1, 'Vukuat.Com', 'http://vukuat.com', 'Vukuat Haber ', '2017 Aljazarisoft.com', '', 1, 'info@aljazarisoft.com', '', '', '', '', '', 1, 1, 0, 1, 1, 0, 1, 0, '25-12-2017 15:40:43', '::1');

INSERT INTO Team ([id], [fullname], [email], [pass], [birddy], [from], [lives], [regdt], [regip], [lastlog], [lastip], [type], [statu], [per]) VALUES
(1, 'admin', 'info@aljazarisoft.com', 'admin', '2017-12-04', '', '', GETUTCDATE(), '', GETUTCDATE(), '', 'admin', 1, 'all');



