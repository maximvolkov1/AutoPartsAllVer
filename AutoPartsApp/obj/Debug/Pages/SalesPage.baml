   M S B A M L   `   `   `  ����G  CAutoPartsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AutoPartsApp.PagesAutoPartsApp.Pages  5      "    AutoPartsApp.Pages.SalesPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:AutoPartsApp.Pages     5        N� 
Background
  ����� N� Title$ 	SalesPage��5	      .��5      � .+�5   
   �� -   5         ��Name$ SalesLV��5      $��	0 80 0 40q�6$   $��Stretch=�67    � ContextMenu 5      �� 5      .@�5      m� -   5         m�Name$ addSale��5   9   $%��Добавить продажу��6   $��15(�6`   $��Copperplate Gothic Bold)�6n   m� 5      -   5        $ delSale��5   8   $#��Удалить продажу��6   $��15(�6_   $��Copperplate Gothic Bold)�6m   m� 5      -   5        $ 
updateSale��5   1   $��Обновить��6   $��15(�6^   $��Copperplate Gothic Bold)�6l   m� 5      -   5        $ calcSale��5   3   $��Вычисление��6   $��15(�6\   $��Copperplate Gothic Bold)�6j   m� 5      -   5        $ 
selectSale��5   /   $��Запрос��6   $��15(�6\   $��Copperplate Gothic Bold)�6j   m� 5      -   5        $ 
reportSale��5   .   $��
Отчет��6   $��15(�6[   $��Copperplate Gothic Bold)�6i   5      ��5      �� 5      .R�5      �  �Name$ MGrid��6    � ColumnDefinitions 5      �� 5      $��0 �6/   �� 5      $��* �6/   �� 5      $��* �6/   �� 5      $��0 �6/   .+�5       �� $��1��6%   $��5q�65   .+�5!      ��  �� Orientation$ 
Horizontal=�6)   .+�5"   "   �� $
��Id: ��6,   $��15(�68   $��Copperplate Gothic Bold)�6F   �� 5#   "   $��15(�6D   $��Copperplate Gothic Bold)�6R   ��6,   �� *IdSale+6R   5$      �� 5%      $ 
Horizontal=�6)   .+�5&   "   �� $��Код продавца: ��6,   $��15(�6B   $��Copperplate Gothic Bold)�6P   �� 5'   "   $��15(�6F   $��Copperplate Gothic Bold)�6T   ��6,   �� *
IdSeller+6T   5(      �� 5)      $ 
Horizontal=�6)   .+�5*   "   �� $��Код клиента: ��6,   $��15(�6A   $��Copperplate Gothic Bold)�6O   �� 5+   "   $��15(�6F   $��Copperplate Gothic Bold)�6T   ��6,   �� *
IdClient+6T   5,      �� 5-      $ 
Horizontal=�6)   .+�5.   "   �� $��Дата заказа: ��6,   $��15(�6A   $��Copperplate Gothic Bold)�6O   �� 5/   "   $��15(�6F   $��Copperplate Gothic Bold)�6T   ��6,   �� *
DateSale+6T   50      �� 51      $ 
Horizontal=�6)   .+�52   "   �� $��Количество: ��6,   $��15(�6@   $��Copperplate Gothic Bold)�6N   �� 53   "   $��15(�6F   $��Copperplate Gothic Bold)�6T   ��6,   �� *
Quantity+6T   54      �� 55      $ 
Horizontal=�6)   .+�56   "   �� $��
Цена: ��6,   $��15(�6:   $��Copperplate Gothic Bold)�6H   �� 57   "   $��15(�6C   $��Copperplate Gothic Bold)�6Q   ��6,   �� *Price+6Q   58      �� 59      $ 
Horizontal=�6)   .+�5:   "   �� $%��Общая стоимость: ��6,   $��15(�6E   $��Copperplate Gothic Bold)�6S   �� 5;   "   $��15(�6G   $��Copperplate Gothic Bold)�6U   ��6,   �� *	TotalCost+6U   5<      5=      �� 5>       ��Name$ editSaleBtn��64   -   5        $��Изменить��5>   !   $��30��6c   $��1��6o   $��Right=�6   $��Center=�6�   $��15(�6�   $��Copperplate Gothic Bold)�6�   
���   ����	#FF7BB8326�   5?      5@      5B      �� 5C   
   -	   5        $��backBtn��5C      $��45��66   $��45��6A   $
��Left=�6M   $	��Top=�6h   $��15,0,0,0q�6�   
���������6�   Z� .��5D      �� $��/Pages/iconBack.png��6   5E      �� 5F   
   $��ООО Автоцентр��6   $	��280��6)   $	��Top=�65   $��36(�6M   $��Copperplate Gothic Bold)�6[   $��Center=�6�   �� 5G   
   $��Поиск:��6   $��70��6"   $��30��6-   $��20(�69   $��Copperplate Gothic Bold)�6G   $
��Left=�6l   $	��Top=�6�   $��	15,50,0,0q�6�   �� 5H   
   -
   5        	 ��Name$	 	searchTxt��5H      $
��Left=�6I   $	��140��6d   $��25��6p   $	��Top=�6|   $��
100,50,0,0q�6�   $	��20 (�6�   $��Copperplate Gothic Bold)�6�   �� 5I   
   $	��С:��6   $��20��6   $��30��6)   $��20(�65   $��Copperplate Gothic Bold)�6C   $	��Top=�6h   $��Right=�6�   $��
0,50,400,0q�6�   �� 5J   
   $��По:��6   $��35��6   $��30��6*   $��20(�66   $��Copperplate Gothic Bold)�6D   $	��Top=�6i   $��Right=�6�   $��
0,50,170,0q�6�   (  "System.Windows.Controls.DatePicker  5K   
   -   5        $��	СDatepkr��5K      $	��140��6%   $��25��61   $	��Top=�6=   $��Right=�6U   $��
0,50,250,0q�6q   6�     5L   
   -   5        
  Name$
 	PoDatepkr��5L      $	��140��6(   $��24��64   $	��Top=�6@   $��Right=�6X   $��480,50,15,0q�6t   6�   �� 5M   
   $��Stretch=�6   $��Bottom=�6/   $��40��6J   ���	#FF7BB8325N      5O      5P      