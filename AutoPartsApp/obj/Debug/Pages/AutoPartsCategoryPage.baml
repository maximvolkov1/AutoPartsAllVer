   M S B A M L   `   `   `  ����G  CAutoPartsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AutoPartsApp.PagesAutoPartsApp.Pages  5      .    (AutoPartsApp.Pages.AutoPartsCategoryPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:AutoPartsApp.Pages     5        N� 
Background
  ����� N� Title$ AutoPartsCategoryPage��5	      .��5      � .+�5   
   �� -   5         ��Name$ AutoPartCategoryLV��5      $��	0 80 0 40q�6/   $��Stretch=�6B    � ContextMenu 5      �� 5      .@�5      m� -   5         m�Name$ addAPC��5   H   $B��<Добавить категорию автозапчасти��6   $��15(�6m   $��Copperplate Gothic Bold)�6{   m� 5      -   5        $ delAPC��5   G   $@��:Удалить категорию автозапчасти��6   $��15(�6l   $��Copperplate Gothic Bold)�6z   m� 5      -   5        $ 	updateAPC��5   1   $��Обновить��6   $��15(�6\   $��Copperplate Gothic Bold)�6j   5      ��5      �� 5      .R�5      �  �Name$ MGrid��6    � ColumnDefinitions 5      �� 5      $��0 �6/   �� 5      $��* �6/   �� 5      $��* �6/   �� 5      $��0 �6/   .+�5      �� $��1��6%   $��5q�65   .+�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� $
��Id: ��6,   $��15(�68   $��Copperplate Gothic Bold)�6F   �� 5    "   $��15(�6Q   $��Copperplate Gothic Bold)�6_   ��6,   �� *IdAutoPartsСategory+6_   5!      �� 5"      $ 
Horizontal=�6)   .+�5#   "   �� $D��>Название категории автозапчасти: ��6,   $��15(�6U   $��Copperplate Gothic Bold)�6c   �� 5$   "   $��15(�6J   $��Copperplate Gothic Bold)�6X   ��6,   �� *NameCategory+6X   5%      5&      �� 5'       ��Name$ 
editAPCBtn��64   -   5        $��Изменить��5'   !   $��30��6a   $��1��6m   $��Center=�6}   $��Center=�6�   $��15(�6�   $��Copperplate Gothic Bold)�6�   $��	400,0,0,0q�6�   
���   ����	#FF7BB8326  5(      5)      5+      �� 5,   
   -   5        $��backBtn��5,      $��45��66   $��45��6A   $
��Left=�6M   $	��Top=�6h   $��15,0,0,0q�6�   
���������6�   Z� .��5-      �� $��/Pages/iconBack.png��6   5.      �� 5/   
   $��ООО Автоцентр��6   $	��280��6)   $	��Top=�65   $��36(�6M   $��Copperplate Gothic Bold)�6[   $��Center=�6�   �� 50   
   $��Поиск:��6   $��70��6"   $��30��6-   $��20(�69   $��Copperplate Gothic Bold)�6G   $
��Left=�6l   $	��Top=�6�   $��	15,50,0,0q�6�   �� 51   
   -   5        	 ��Name$	 	searchTxt��51      $
��Left=�6I   $	��140��6d   $��25��6p   $	��Top=�6|   $��
100,50,0,0q�6�   $	��20 (�6�   $��Copperplate Gothic Bold)�6�   �� 52   
   $��Stretch=�6   $��Bottom=�6/   $��40��6J   ���	#FF7BB83253      54      55      