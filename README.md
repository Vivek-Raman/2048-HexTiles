# 2048-HexTiles
A 2048 clone with development plans for a hexagonal grid.

## About 2048

2048 is a popular hyper-casual game that involves directing numbered tiles towards each other to sum them up.

## Components

<dl>
  <dt> Grid </dt>
  <dd> The game is played on a 4x4 grid that spawns two tiles at the start and one every turn. </dd>
  
  <dt> Tile </dt>
  <dd> Tiles contain powers of 2, from 2 to 2048. Like tiles can be combined to give a new tile with a higher power. </dd>
  
  <dt> Score </dt>
  <dd> -to be implemented- </dd>
</dl>

## Controls
The control system consists of a simple fur directional swipe gesture.
When an input is registered, every tile looks to the direction of the swipe.
- If a free space exists, the tile is moved to it.
- If a like tile exists, the tile disappears and the other tile's power is increased.
- If a grid boundary exists, the next tile is checked.
- If an unlike tile exists, the next tile is checked.

#### Note
Tiles are traversed from the direction of swipe.
Movement is determined first, then combination.

## Win Condition
The game is won when a 2048 tile is achieved.

## Loss Condition
The game ends when the grid is filled and no like tiles can combine.
