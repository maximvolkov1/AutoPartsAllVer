   M S B A M L   `   `   `  ����G  CAutoPartsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AutoPartsApp.PagesAutoPartsApp.Pages  5      #    AutoPartsApp.Pages.OrdersPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:AutoPartsApp.Pages     5        N� 
Background
  ����� N� Title$ 
OrdersPage��5	      .��5      � .+�5   
   �� -   5         ��Name$ OrdersLV��5      $��	0 80 0 40q�6%   $��Stretch=�68    � ContextMenu 5      �� 5      .@�5      m� -   5         m�Name$ addOrder��5   7   $!��Добавить заказ��6   $��15(�6`   $��Copperplate Gothic Bold)�6n   m� 5      -   5        $ delOrder��5   6   $��Удалить заказ��6   $��15(�6_   $��Copperplate Gothic Bold)�6m   m� 5      -   5        $��	calcOrder��5   3   $��Вычисление��6   $��15(�6\   $��Copperplate Gothic Bold)�6j   m� 5      -   5        $ updateOrder��5   1   $��Обновить��6   $��15(�6`   $��Copperplate Gothic Bold)�6n   m� 5      -   5        $ reportOrder��5   .   $��
Отчет��6   $��15(�6]   $��Copperplate Gothic Bold)�6k   5      ��5      �� 5      .R�5      �  �Name$ MGrid��6    � ColumnDefinitions 5      �� 5      $��0 �6/   �� 5      $��* �6/   �� 5      $��* �6/   �� 5      $��0 �6/   .+�5      �� $��1��6%   $��5q�65   .+�5       ��  �� Orientation$ 
Horizontal=�6)   .+�5!   "   �� $
��Id: ��6,   $��15(�68   $��Copperplate Gothic Bold)�6F   �� 5"   "   $��15(�6E   $��Copperplate Gothic Bold)�6S   ��6,   �� *	IdOrder+6S   5#      �� 5$      $ 
Horizontal=�6)   .+�5%   "   �� $��Код продавца: ��6,   $��15(�6B   $��Copperplate Gothic Bold)�6P   �� 5&   "   $��15(�6F   $��Copperplate Gothic Bold)�6T   ��6,   �� *
IdSeller+6T   5'      �� 5(      $ 
Horizontal=�6)   .+�5)   "   �� $'��!Код автозапчасти: ��6,   $��15(�6F   $��Copperplate Gothic Bold)�6T   �� 5*   "   $��15(�6H   $��Copperplate Gothic Bold)�6V   ��6,   �� *
IdAutoPart+6V   5+      �� 5,      $ 
Horizontal=�6)   .+�5-   "   �� $��Код клиента: ��6,   $��15(�6A   $��Copperplate Gothic Bold)�6O   �� 5.   "   $��15(�6F   $��Copperplate Gothic Bold)�6T   ��6,   �� *
IdClient+6T   5/      �� 50      $ 
Horizontal=�6)   .+�51   "   �� $��Дата заказа: ��6,   $��15(�6A   $��Copperplate Gothic Bold)�6O   �� 52   "   $��15(�6G   $��Copperplate Gothic Bold)�6U   ��6,   �� *	DateOrder+6U   53      �� 54      $ 
Horizontal=�6)   .+�55   "   �� $��Количество: ��6,   $��15(�6@   $��Copperplate Gothic Bold)�6N   �� 56   "   $��15(�6F   $��Copperplate Gothic Bold)�6T   ��6,   �� *
Quantity+6T   57      �� 58      $ 
Horizontal=�6)   .+�59   "   �� $��
Цена: ��6,   $��15(�6:   $��Copperplate Gothic Bold)�6H   �� 5:   "   $��15(�6C   $��Copperplate Gothic Bold)�6Q   ��6,   �� *Price+6Q   5;      �� 5<      $ 
Horizontal=�6)   .+�5=   "   �� $��Статус: ��6,   $��15(�6<   $��Copperplate Gothic Bold)�6J   �� 5>   "   $��15(�6D   $��Copperplate Gothic Bold)�6R   ��6,   �� *Stasus+6R   5?      �� 5A      $ 
Horizontal=�6)   .+�5B   "   �� $%��Общая стоимость: ��6,   $��15(�6E   $��Copperplate Gothic Bold)�6S   �� 5C   "   $��15(�6G   $��Copperplate Gothic Bold)�6U   ��6,   �� *	TotalCost+6U   5D      5E      �� 5F       ��Name$ editOrderBtn��64   -   5        $��Изменить��5F   !   $��30��6e   $��1��6q   $��Right=�6�   $��Center=�6�   $��15(�6�   $��Copperplate Gothic Bold)�6�   
���   ����	#FF7BB8326�   5G      5H      5J      �� 5K   
   -   5        $��backBtn��5K      $��45��66   $��45��6A   $
��Left=�6M   $	��Top=�6h   $��15,0,0,0q�6�   
���������6�   Z� .��5L      �� $��/Pages/iconBack.png��6   5M      �� 5N   
   $��ООО Автоцентр��6   $	��280��6)   $	��Top=�65   $��36(�6M   $��Copperplate Gothic Bold)�6[   $��Center=�6�   �� 5O   
   $��Поиск:��6   $��70��6"   $��30��6-   $��20(�69   $��Copperplate Gothic Bold)�6G   $
��Left=�6l   $	��Top=�6�   $��	15,50,0,0q�6�   �� 5P   
   -	   5        	 ��Name$	 	searchTxt��5P      $
��Left=�6I   $	��140��6d   $��25��6p   $	��Top=�6|   $��
100,50,0,0q�6�   $	��20 (�6�   $��Copperplate Gothic Bold)�6�   �� 5Q   
   $	��С:��6   $��20��6   $��30��6)   $��20(�65   $��Copperplate Gothic Bold)�6C   $	��Top=�6h   $
��Left=�6�   $��
255,50,0,0q�6�   �� 5R   
   $��По:��6   $��35��6   $��30��6*   $��20(�66   $��Copperplate Gothic Bold)�6D   $	��Top=�6i   $
��Left=�6�   $��
430,50,0,0q�6�   (  "System.Windows.Controls.DatePicker  5S   
   -
   5        $��	СDatepkr��5S      $	��140��6%   $��25��61   $	��Top=�6=   $
��Left=�6U   $��
280,50,0,0q�6p   6�     5T   
   -   5        
  Name$
 	PoDatepkr��5T      $	��140��6(   $��24��64   $	��Top=�6@   $
��Left=�6X   $��
480,50,0,0q�6s   6�   �� 5U   
   $��Статус:��6   $��70��6#   $��30��6.   $��20(�6:   $��Copperplate Gothic Bold)�6H   $	��Top=�6m   $��Right=�6�   $��	0,50,95,0q�6�   �� 5V   
   -   5        $��	statusCbx��5V      $��80��6$   $��25��6/   $	��Top=�6;   $��	0,50,10,0q�6S   $��Right=�6f   6�   �� 5W   
   $��Stretch=�6   $��Bottom=�6/   $��40��6J   ���	#FF7BB8325X      5Y      5Z      