   M S B A M L   `   `   `  ����G  CAutoPartsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AutoPartsApp.PagesAutoPartsApp.Pages  5      $    AutoPartsApp.Pages.ClientsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:AutoPartsApp.Pages     5        N� 
Background
  ����� N� Title$ ClientsPage��5	      .��5      � .+�5   
   �� -   5         ��Name$ 	ClientsLV��5      $��	0 80 0 40q�6&   $��Stretch=�69    � ContextMenu 5      �� 5      .@�5      m� -   5         m�Name$ 	addClient��5   9   $%��Добавить клиента��6   $��15(�6d   $��Copperplate Gothic Bold)�6r   m� 5      -   5        $ 	delClient��5   8   $#��Удалить клиента��6   $��15(�6c   $��Copperplate Gothic Bold)�6q   m� 5      -   5        $ updateClient��5   1   $��Обновить��6   $��15(�6b   $��Copperplate Gothic Bold)�6p   m� 5      -   5        $ reportClient��5   .   $��
Отчет��6   $��15(�6_   $��Copperplate Gothic Bold)�6m   5      ��5      �� 5      .R�5      �  �Name$ MGrid��6    � ColumnDefinitions 5      �� 5      $��0 �6/   �� 5      $��* �6/   �� 5      $��* �6/   �� 5      $��0 �6/   .+�5      �� $��1��6%   $��5q�65   .+�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5    "   �� $
��Id: ��6,   $��15(�68   $��Copperplate Gothic Bold)�6F   �� 5!   "   $��15(�6F   $��Copperplate Gothic Bold)�6T   ��6,   �� *
IdClient+6T   5"      �� 5#      $ 
Horizontal=�6)   .+�5$   "   �� $��Имя: ��6,   $��15(�69   $��Copperplate Gothic Bold)�6G   �� 5%   "   $��15(�6H   $��Copperplate Gothic Bold)�6V   ��6,   �� *
NameClient+6V   5&      �� 5'      $ 
Horizontal=�6)   .+�5(   "   �� $��Фамилия: ��6,   $��15(�6=   $��Copperplate Gothic Bold)�6K   �� 5)   "   $��15(�6K   $��Copperplate Gothic Bold)�6Y   ��6,   �� *SurnameClient+6Y   5*      �� 5+      $ 
Horizontal=�6)   .+�5,   "   �� $��Адрес: ��6,   $��15(�6;   $��Copperplate Gothic Bold)�6I   �� 5-   "   $��15(�6D   $��Copperplate Gothic Bold)�6R   ��6,   �� *Addres+6R   5.      �� 5/      $ 
Horizontal=�6)   .+�50   "   �� $��Телефон: ��6,   $��15(�6=   $��Copperplate Gothic Bold)�6K   �� 51   "   $��15(�6C   $��Copperplate Gothic Bold)�6Q   ��6,   �� *Phone+6Q   52      53      �� 54       ��Name$ editClientBtn��64   -   5        $��Изменить��54   !   $��30��6g   $��1��6s   $��Center=�6�   $��Center=�6�   $��15(�6�   $��Copperplate Gothic Bold)�6�   $��	150,0,0,0q�6�   
���   ����	#FF7BB8326  55      56      58      �� 59   
   -   5        $��backBtn��59      $��45��66   $��45��6A   $
��Left=�6M   $	��Top=�6h   $��15,0,0,0q�6�   
���������6�   Z� .��5:      �� $��/Pages/iconBack.png��6   5;      �� 5<   
   $��ООО Автоцентр��6   $	��280��6)   $	��Top=�65   $��36(�6M   $��Copperplate Gothic Bold)�6[   $��Center=�6�   �� 5=   
   $��Поиск:��6   $��70��6"   $��30��6-   $��20(�69   $��Copperplate Gothic Bold)�6G   $
��Left=�6l   $	��Top=�6�   $��	15,50,0,0q�6�   �� 5>   
   -   5        	 ��Name$	 	searchTxt��5>      $
��Left=�6I   $	��140��6d   $��25��6p   $	��Top=�6|   $��
100,50,0,0q�6�   $	��20 (�6�   $��Copperplate Gothic Bold)�6�   �� 5?   
   $��Stretch=�6   $��Bottom=�6/   $��40��6J   ���	#FF7BB8325@      5A      5B      