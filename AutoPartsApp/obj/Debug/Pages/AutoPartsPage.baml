   M S B A M L   `   `   `  ����G  CAutoPartsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AutoPartsApp.PagesAutoPartsApp.Pages  5      &     AutoPartsApp.Pages.AutoPartsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:AutoPartsApp.Pages     5        N� 
Background
  ����� N� Title$ AutoPartsPage��5	      .��5      � .+�5   
   �� -   5         ��Name$ 
AutoPartLV��5      $��	0 80 0 40q�6'   $��Stretch=�6:    � ContextMenu 5      �� 5      .@�5      m� -   5         m�Name$ addAutoPart��5   >   $/��)Добавить автозапчасть��6   $��15(�6m   $��Copperplate Gothic Bold)�6{   m� 5      -   5        $ delAutoPart��5   =   $-��'Удалить автозапчасть��6   $��15(�6l   $��Copperplate Gothic Bold)�6z   m� 5      -   5        $ updateAutoPart��5   1   $��Обновить��6   $��15(�6f   $��Copperplate Gothic Bold)�6t   5      ��5      �� 5      .R�5      �  �Name$ MGrid��6    � ColumnDefinitions 5      �� 5      $��0 �6/   �� 5      $��* �6/   �� 5      $��* �6/   �� 5      $��0 �6/   .+�5      �� $��1��6%   $��5q�65   .+�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5    "   �� $
��Id: ��6,   $��15(�68   $��Copperplate Gothic Bold)�6F   �� 5!   "   $��15(�6H   $��Copperplate Gothic Bold)�6V   ��6,   �� *
IdAutoPart+6V   5"      �� 5#      $ 
Horizontal=�6)   .+�5$   "   �� $1��+Название автозапчасти: ��6,   $��15(�6K   $��Copperplate Gothic Bold)�6Y   �� 5%   "   $��15(�6K   $��Copperplate Gothic Bold)�6Y   ��6,   �� *NameAutoParts+6Y   5&      �� 5'      $ 
Horizontal=�6)   .+�5(   "   �� $:��4Код категории автозапчасти: ��6,   $��15(�6P   $��Copperplate Gothic Bold)�6^   �� 5)   "   $��15(�6Q   $��Copperplate Gothic Bold)�6_   ��6,   �� *IdAutoPartsСategory+6_   5*      �� 5+      $ 
Horizontal=�6)   .+�5,   "   �� $��Описание: ��6,   $��15(�6>   $��Copperplate Gothic Bold)�6L   �� 5-   "   $��15(�6Q   $��Copperplate Gothic Bold)�6_   ��6,   �� *DescriptionAutoPart+6_   5.      �� 5/      $ 
Horizontal=�6)   .+�50   "   �� $��В наличии: ��6,   $��15(�6?   $��Copperplate Gothic Bold)�6M   �� 51   "   $��15(�6E   $��Copperplate Gothic Bold)�6S   ��6,   �� *	InStock+6S   52      �� 53      $	��150��6$   ��54   "   �� 55   &    �� Path$ Photo�6.   	 �� TargetNullValue	 56   *   ��57   .   ..\Pages\noImageIcon.png��6T   59   '   5;      �� 5<      $ 
Horizontal=�6)   .+�5=   "   �� $��
Цена: ��6,   $��15(�6:   $��Copperplate Gothic Bold)�6H   �� 5>   "   $��15(�6C   $��Copperplate Gothic Bold)�6Q   ��6,   �� *Price+6Q   5?      5@      �� 5A      
 ��Name$
 editAutoPartBtn��64   -   5        $��Изменить��5A   !   $��30��6k   $��1��6w   $��Right=�6�   $��Center=�6�   $��15(�6�   $��Copperplate Gothic Bold)�6�   
���   ����	#FF7BB8326  5B      5C      5E      �� 5F   
   -   5        $��backBtn��5F      $��45��66   $��45��6A   $
��Left=�6M   $	��Top=�6h   $��15,0,0,0q�6�   
���������6�   Z� .��5G      �� $��/Pages/iconBack.png��6   5H      �� 5I   
   $��ООО Автоцентр��6   $	��280��6)   $	��Top=�65   $��36(�6M   $��Copperplate Gothic Bold)�6[   $��Center=�6�   �� 5J   
   $��Поиск:��6   $��70��6"   $��30��6-   $��20(�69   $��Copperplate Gothic Bold)�6G   $
��Left=�6l   $	��Top=�6�   $��	15,50,0,0q�6�   �� 5K   
   -   5         ��Name$ 	searchTxt��5K      $
��Left=�6I   $	��140��6d   $��25��6p   $	��Top=�6|   $��
100,50,0,0q�6�   $	��20 (�6�   $��Copperplate Gothic Bold)�6�   �� 5L   
   $��Категория:��6   $	��105��6&   $��30��62   $��20(�6>   $��Copperplate Gothic Bold)�6L   $��Right=�6q   $	��Top=�6�   $��
0,50,220,0q�6�   �� 5M   
   -   5        $��APCcbx��5M      $	��180��6!   $��30��6-   $��Right=�69   $	��Top=�6U   $��	0,45,20,0q�6m    �� DisplayMemberPath$ NameCategory��6�   ��6�   �� *AutoPartsCategory+6�   �� 5N   
   $��Stretch=�6   $��Bottom=�6/   $��40��6J   ���	#FF7BB8325O      5P      5Q      